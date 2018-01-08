using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeProblems
{
    /// <summary>
    /// Question #4 - Your company built an in-house calendar tool called HiCal. 
    /// You want to add a feature to see the times in a day when everyone is available.
    /// Write a method MergeRanges() that takes a list of meeting time ranges and returns a list of condensed ranges.
    /// </summary>
    public class Meeting
    {
        public int StartTime { get; set; }

        public int EndTime { get; set; }

        public Meeting(int startTime, int endTime)
        {
            // Number of 30 min blocks past 9:00 am
            StartTime = startTime;
            EndTime = endTime;
        }

        public override string ToString()
        {
            return $"({StartTime}, {EndTime})";
        }
    }

    public class HiCal
    {
        public List<Meeting> MergeRanges(List<Meeting> meetings)
        {
            var sortedMeetings = meetings.Select(m => new Meeting(m.StartTime, m.EndTime))
                .OrderBy(m => m.StartTime).ToList();

            List<Meeting> mergedMeetings = new List<Meeting>() { sortedMeetings[0] };

            foreach (Meeting currentMeeting in sortedMeetings)
            {
                var lastMergedMeeting = mergedMeetings.Last();

                // If the current and last meetings overlap, use the latest end time
                if (currentMeeting.StartTime <= lastMergedMeeting.EndTime)
                {
                    lastMergedMeeting.EndTime = Math.Max(lastMergedMeeting.EndTime, currentMeeting.EndTime);
                }
                else
                {
                    // Add the current meeting since it doesn't overlap
                    mergedMeetings.Add(currentMeeting);
                }
            }

            return mergedMeetings;
        }
    }
}
