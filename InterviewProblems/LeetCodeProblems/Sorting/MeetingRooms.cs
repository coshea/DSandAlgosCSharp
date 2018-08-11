using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Sorting
{
    public class Interval
    {
        public int start;
        public int end;
        public Interval() { start = 0; end = 0; }
        public Interval(int s, int e) { start = s; end = e; }
    }

    public class MeetingRooms
    {
        /// <summary>
        /// 252. Meeting Rooms
        /// Given an array of meeting time intervals consisting of start and end times
        /// determine if a person could attend all meetings.
        /// </summary>
        /// <param name="intervals"></param>
        /// <returns></returns>
        public bool CanAttendMeetings(Interval[] intervals)
        {
            Array.Sort(intervals, (x, y) => x.start - y.start);

            for (int i = 0; i < intervals.Length - 1; i++)
            {
                if (intervals[i].end > intervals[i + 1].start)
                    return false;
            }

            return true;
        }


        /// <summary>
        /// 253. Meeting Rooms II
        /// Given an array of meeting time intervals consisting of start and end times
        /// find the minimum number of conference rooms required.
        /// </summary>
        /// <param name="intervals"></param>
        /// <returns></returns>
        public int MinMeetingRooms(Interval[] intervals)
        {
            int rooms = 0;
            Array.Sort(intervals, (x, y) => x.start - y.start);



            return rooms;
        }

    }
}
