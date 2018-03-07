using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeProblems.Design
{
    public class FilePaths
    {
        public string DuplicatePath { get; }

        public string OriginalPath { get; }

        public FilePaths(string duplicatePath, string originalPath)
        {
            DuplicatePath = duplicatePath;
            OriginalPath = originalPath;
        }

        public override string ToString()
        {
            return $"(original: {OriginalPath}, duplicate: {DuplicatePath})";
        }
    }

    /// <summary>
    /// Problem #42
    /// Write a method that returns an array of all the duplicate files.
    /// The duplicate files have random file names.
    /// </summary>
    public class DuplicateFiles
    {
        public List<FilePaths> FindDuplicateFiles(string startingDirectory)
        {
            var filesSeenAlready = new Dictionary<string, FileInfo>();
            var stack = new Stack<FileSystemInfo>();
            stack.Push(new DirectoryInfo(startingDirectory));

            var duplicates = new List<FilePaths>();

            while (stack.Count > 0)
            {
                var currentInfo = stack.Pop();

                // If it's a directory, put the contents in our stack
                DirectoryInfo currentDirectoryInfo = currentInfo as DirectoryInfo;
                if (currentDirectoryInfo != null)
                {
                    foreach (var info in currentDirectoryInfo.GetFileSystemInfos())
                    {
                        stack.Push(info);
                    }
                }

                // If it's a file
                FileInfo currentFileInfo = currentInfo as FileInfo;
                if (currentFileInfo == null)
                {
                    continue;
                }

                // Get its hash
                var fileHash = SampleHashFile(currentFileInfo);


                // If we've seen it before
                if (filesSeenAlready.ContainsKey(fileHash))
                {
                    FileInfo existingFileInfo = filesSeenAlready[fileHash];

                    if (currentFileInfo.LastWriteTime > existingFileInfo.LastWriteTime)
                    {
                        // Current file is the dupe!
                        duplicates.Add(new FilePaths(currentFileInfo.FullName, existingFileInfo.FullName));
                    }
                    else
                    {
                        // Other file is the dupe!
                        duplicates.Add(new FilePaths(existingFileInfo.FullName, currentFileInfo.FullName));

                        // But also update filesSeenAlready to have the new file's info
                        filesSeenAlready[fileHash] = currentFileInfo;
                    }
                }
                else
                {
                    // Throw new files in filesSeenAlready so we can compare it later
                    filesSeenAlready[fileHash] = currentFileInfo;
                }
            }

            return duplicates;
        }

        public string SampleHashFile(FileInfo fileInfo)
        {
            int sampleSize = 4000;
            long totalBytes = fileInfo.Length;

            byte[] digestBytes;
            using (var fileStream = fileInfo.OpenRead())
            {
                using (var fileReader = new BinaryReader(fileStream))
                {
                    // If the file is too short to take 3 samples, hash the entire file
                    if (totalBytes < sampleSize * 3)
                    {
                        digestBytes = fileReader.ReadBytes((int)totalBytes);
                    }
                    else
                    {
                        long numBytesBetweenSamples = (totalBytes - (sampleSize * 3)) / 2;
                        digestBytes = new byte[sampleSize * 3];

                        // Read first, middle and last bytes
                        for (int i = 0; i < 3; i++)
                        {
                            var sectionBytes = fileReader.ReadBytes(sampleSize);
                            sectionBytes.CopyTo(digestBytes, i * sampleSize);
                            fileStream.Seek(numBytesBetweenSamples, SeekOrigin.Current);
                        }
                    }
                }
            }

            using (var sha = new SHA256Managed())
            {
                var hash = sha.ComputeHash(digestBytes);
                return BitConverter.ToString(hash).Replace("-", string.Empty);
            }
        }
    }
}
