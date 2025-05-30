using LearningBasics._5.Graphs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics._7.Questions.PracticePlace.Graphs
{
    public class CanFinishClass
    {
        HashSet<int> courses = new();
        Dictionary<int,List<int>> PreMap = new();
        public CanFinishClass()
        {
            int[][] prerequisites = [[0, 1], [0,2], [1,3], [1, 4], [3,4]];
           // int[][] prerequisites = [[0, 1], [1, 0]];
           Console.Write(CanFinish(2, prerequisites));
        }

        public bool CanFinish(int numCourses, int[][] prerequisites)
        {
            foreach (var course in prerequisites)
            {
                if (!PreMap.ContainsKey(course[0]))
                {
                    PreMap.Add(course[0],new List<int> { });
                }
                PreMap[course[0]].Add(course[1]);
            }
            for (int classes = 0; classes < numCourses; classes++)
            {
                if (!Dfs(classes))
                {
                    return false;
                }

            }
            return true;
        }

        private bool Dfs(int classes)
        {
            if (courses.Contains(classes)) return false;

            if (!PreMap.ContainsKey(classes) || PreMap[classes] == null) return true;

            courses.Add(classes);
            foreach (var preReq in PreMap[classes])
            {
                if (!Dfs(preReq))
                {
                    return false;
                }
            }
            courses.Remove(classes);
            PreMap[classes].Clear();
            return true;
        }
    }

}

