using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeProblems.Strings
{
    /// <summary>
    /// Problem #27
    /// Write a method ReverseWords() that takes a message as an 
    /// array of characters and reverses the order of the words in-place
    /// </summary>
    public class ReverseWords
    {
        /// <summary>
        /// In place implentation. Trick is reverse whole string, then each word
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public string ReverseInPlace(string message)
        {
            var messageArray = message.ToCharArray();

            // First we reverse all the characters in the entire message array
            // This gives us the right word order,
            // but with each word backwards.
            // Now we'll make the words forward again
            // by reversing each word's characters
            ReverseCharacters(messageArray, 0, messageArray.Length - 1);
                       
            var leftIndex = 0;

            // Reverse each word
            // We hold the index of the *start* of the current word
            // as we look for the *end* of the current word
            for (int i = 0; i <= messageArray.Length; i++)
            {
                // Found the end of the current word!
                if (i == messageArray.Length || messageArray[i] == ' ')
                {
                    ReverseCharacters(messageArray, leftIndex, i - 1);
                    leftIndex = i + 1;
                }
            }
            
            return new string(messageArray);
        }

        private void ReverseCharacters(char[] message, int leftIndex, int rightIndex)
        {
            while (leftIndex < rightIndex)
            {
                char left = message[leftIndex];
                char right = message[rightIndex];

                message[leftIndex] = right;
                message[rightIndex] = left;

                leftIndex++;
                rightIndex--;
            }
        }

        /// <summary>
        /// My implementation
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public string ReverseWithHelpers(string message)
        {
            string[] splitMessage = message.Split(' ');

            string[] reverseArray = splitMessage.Reverse().ToArray();

            StringBuilder newMessage = new StringBuilder();
            for (int i = 0; i < reverseArray.Length; i++)
            {
                newMessage.Append(reverseArray[i]);

                if (i != reverseArray.Length - 1)
                {
                    newMessage.Append(" ");
                }
            }

            return newMessage.ToString();
        }
        
    }
}
