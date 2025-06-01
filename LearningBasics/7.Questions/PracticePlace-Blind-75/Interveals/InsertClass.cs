using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LearningBasics._7.Questions.PracticePlace.DP._6.DynamicProgramming
{
    public class InsertClass
    {

        public InsertClass()
        {
            int[][] intervals = [[1, 40], [5, 10], [15, 20]];

            List<Interval> theList = BuildInterval(intervals);

            CanAttendMeetings(theList);
            MinMeetingRooms(theList);


        }

        public int MinMeetingRooms(List<Interval> intervals)
        {
            int[] start = new int[intervals.Count];
            int[] end = new int[intervals.Count];

            for (int i = 0; i < intervals.Count; i++)
            {
                start[i] = intervals[i].start;
            }
            for (int i = 0; i < intervals.Count; i++)
            {
                end[i] = intervals[i].end;
            }
            int result = 0, count = 0;

            Array.Sort(start);
            Array.Sort(end);

            int startTime = 0, endTime = 0;
            while (startTime < start.Length)
            {
                if (start[startTime] < end[endTime])
                {
                    startTime++;
                    count++;
                }
                else
                {
                    endTime++;
                    count--;
                }
                result = Math.Max(result, count);
            }
            return result;
        }

        public bool CanAttendMeetings(List<Interval> intervals)
        {
            intervals.Sort((a, b) => a.start.CompareTo(b.start));
            int previousIntervalEnd = 0;
            foreach (var interval in intervals)
            {
                int nextIntervalStart = interval.start;
                int nextIntervalEnd = interval.end;

                if (nextIntervalStart >= previousIntervalEnd)
                {
                    previousIntervalEnd = nextIntervalEnd;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        public int[][] Insert(int[][] intervals, int[] newInterval)
        {
            var result = new List<int[]>();

            for (int i = 0; i < intervals.Length; i++)
            {
                //does this new interval go before what we currently have?
                //because it goes before, we can just add the rest 
                if (newInterval[1] < intervals[i][0])
                {
                    result.Add(newInterval);
                    result.AddRange(intervals.AsEnumerable().Skip(i).ToArray());
                    return result.ToArray();
                }

                else if (newInterval[0] > intervals[i][1]) result.Add(intervals[i]);
                else
                {
                    newInterval[0] = Math.Min(intervals[i][0], newInterval[0]);
                    newInterval[1] = Math.Max(intervals[i][1], newInterval[1]);

                }
            }
            result.Add(newInterval);

            return result.ToArray();
        }

        public int[][] Merge(int[][] intervals)
        {
            List<int[]> resultsList = new();
            Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

            resultsList.Add(intervals[0]);
            foreach (var interval in intervals)
            {
                int start = interval[0];
                int end = interval[1];
                int lastEnd = resultsList[resultsList.Count - 1][1];

                if (start <= lastEnd)
                {
                    resultsList[resultsList.Count - 1][1] = Math.Max(lastEnd, end);
                }
                else
                {
                    resultsList.Add(new int[] { start, end });
                }
            }
            return resultsList.ToArray();
        }

        public int EraseOverlapIntervals(int[][] intervals)
        {
            Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
            int result = 0;
            int prevEnd = intervals[0][1];

            for (int i = 1; i < intervals.Length; i++)
            {
                int start = intervals[i][0];
                int end = intervals[i][1];

                ///DONT overlap 
                if (start >= prevEnd)
                {
                    prevEnd = end;
                }
                //does overlap
                else
                {
                    result++;
                    prevEnd = Math.Min(prevEnd, end);

                }
            }
            return result;
        }

        public List<Interval> BuildInterval(int[][] interval)
        {
            List<Interval> returnList = new();
            for (int i = 0; i < interval.Length; i++)
            {
                Interval temp = new(interval[i][0], interval[i][1]);
                returnList.Add(temp);
            }
            return returnList;
        }
    }
    public class Interval
    {
        public int start, end;
        public Interval(int start, int end)
        {
            this.start = start;
            this.end = end;
        }
    }


}
