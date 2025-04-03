using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.PracticePlace
{
    public class _2pointer
    {
        public static bool IsPalindrome(string s)
        {
            int left = 0;
            int right = s.Length - 1;
            for (int i = 0; i < s.Length; i++)
            {
                if (left > right)
                {
                    return true;
                }
                if (!char.IsLetterOrDigit(s[left]))
                {
                    left++;
                }
                if (!char.IsLetterOrDigit(s[right]))
                {
                    right--;
                }
                if (char.ToLower(s[left]) == char.ToLower(s[right]))
                {
                    left++;
                    right--;
                }
            }
            return false;
        }
        public int[] TwoSum(int[] numbers, int target)
        {
            /*return the indices(1 - indexed) of two numbers, [index1, index2], such that they add up to a given target number target and index1<index2.Note that index1 and index2 cannot be equal, therefore you may not use the same element twice.
            There will always be exactly one valid solution.
            Your solution must use O(1) additional space.
            */

            int leftPointer = 0;
            int rightPointer = numbers.Length - 1;

            Array.Sort(numbers);

            while (leftPointer < rightPointer)
            {
                if (numbers[leftPointer] + numbers[rightPointer] == target)
                {
                    return new int[] { leftPointer + 1, rightPointer + 1 };
                }

                if (numbers[leftPointer] + numbers[rightPointer] > target)
                {
                    rightPointer--;
                }
                else if (numbers[leftPointer] + numbers[rightPointer] < target)
                {
                    leftPointer++;
                }


            }
            return new int[] { -1 };
        }
        public static List<List<int>> ThreeSum(int[] nums)
        {
            List<List<int>> results = new();

            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0) break;
                if (i > 0 && nums[i] == nums[i - 1]) continue;

                int leftPointer = i + 1, RightPointer = nums.Length - 1;

                while (leftPointer < RightPointer)
                {
                    int sum = nums[i] + nums[leftPointer] + nums[RightPointer];
                    if (sum > 0)
                    {
                        RightPointer--;
                    }
                    else if (sum < 0)
                    {
                        leftPointer++;
                    }
                    else
                    {
                        results.Add(new List<int> { nums[i], nums[leftPointer], nums[RightPointer] });
                        leftPointer++;
                        RightPointer--;
                        while (leftPointer < RightPointer && nums[leftPointer] == nums[leftPointer - 1])
                        {
                            leftPointer++;
                        }
                    }
                }
            }
            return results;
        }
        public static int MaxArea(int[] heights)
        {
            /* You are given an integer array heights where heights[i] represents the height of the ith bar.
                You may choose any two bars to form a container. Return the maximum amount of water a container can store. */
            //[1,7,2,5,4,7,3,6]
            int leftPointer = 0;
            int rightPointer = heights.Length - 1;
            int area = 0;

            int min = Math.Min(heights[leftPointer], heights[rightPointer]);
            while (leftPointer < rightPointer)
            {
                int newArea = (rightPointer - leftPointer) * Math.Min(heights[leftPointer], heights[rightPointer]);

                if (heights[leftPointer] <= heights[rightPointer])
                {
                    leftPointer++;
                }
                else
                {
                    rightPointer--;
                }
                area = Math.Max(area, newArea);
            }
            Console.WriteLine(area);
            return area;

        }

        public static int MaxProfit(int[] prices)
        {//[10,1,5,6,7,1]
            int leftPointer = 0;
            int rightPointer = 1;
            int maxProfit = 0;
            for (int i = 0; i < prices.Length - 1; i++)
            {

                maxProfit = Math.Max(maxProfit, prices[rightPointer] - prices[leftPointer]);
                if (prices[rightPointer] < prices[leftPointer])
                {
                    leftPointer = rightPointer;
                    rightPointer++;
                }
                else
                {
                    rightPointer++;
                }
            }
            return maxProfit;
        }

        public static int LengthOfLongestSubstring(string s = "abcabcbb")
        {
            Dictionary<char, int> map = new();
            int leftPointer = 0, results = 0; ;

            for (int rightPointer = 0; rightPointer < s.Length; rightPointer++)
            {

                if (map.ContainsKey(s[rightPointer]))
                {
                    leftPointer = Math.Max(leftPointer, map[s[rightPointer]] + 1);
                    int test = map[s[rightPointer]] + 1;
                }
                map[s[rightPointer]] = rightPointer;
                results = Math.Max(results, rightPointer - leftPointer + 1);
            }
            return results;
        }

        public static int CharacterReplacement(string s = "ABAB", int k = 2)
        {
            //sim has bad read ability 
            int replaceNumber = k;
            string str = s;

            HashSet<char> charsSet = new(str);
            int result = 0;

            foreach (char chr in charsSet)
            {
                int countCurrentLetter = 0, leftPointer = 0;
                for (int rightPointer = 0; rightPointer < s.Length; rightPointer++)
                {
                    if (s[rightPointer] == chr)
                    {
                        countCurrentLetter++;
                    }
                    while ((rightPointer - leftPointer + 1) - countCurrentLetter > replaceNumber)
                    {
                        if (str[leftPointer] == chr)
                        {
                            countCurrentLetter--;
                        }
                        leftPointer++;
                    }
                    result = Math.Max(result, rightPointer - leftPointer + 1);
                }
            }
            return result;
        }
        public int CharacterReplacementOP(string s, int k)
        {
            int[] charCounts = new int[26];
            int left = 0, maxCount = 0, maxLength = 0;

            for (int right = 0; right < s.Length; right++)
            {
                charCounts[s[right] - 'A']++;
                maxCount = Math.Max(maxCount, charCounts[s[right] - 'A']);

                // If more than k characters need to be replaced, shrink window
                if ((right - left + 1) - maxCount > k)
                {
                    charCounts[s[left] - 'A']--;
                    left++;
                }
                maxLength = Math.Max(maxLength, right - left + 1);
            }
            return maxLength;
        }
        public static bool CheckInclusion(string s1, string s2)
        {
            if (s1.Length > s2.Length)
            {
                return false;
            }
            int[] s1Count = new int[26];
            int[] s2Count = new int[26];
            int left = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                s1Count[s1[i] - 'a']++;
                s2Count[s2[i] - 'a']++;
            }
            int matches = 0;
            for (int right = s1.Length; right < s2.Length; right++)
            {
                if (matches == 26)
                {
                    return true;
                }
                int index = s2[right] - 'a';
                s2Count[index]++;
                if (s1Count[index] == s2Count[index])
                {
                    matches++;
                }
                else if (s1Count[index] - 1 == s2Count[index])
                {
                    matches--;
                }
                left++;
            }
            return matches == 26;
        }
        public static bool CheckInclusionOPT(string s1, string s2)
        {
            Dictionary<char, int> count1 = new();
            foreach (char chrs in s1)
            {
                if (count1.ContainsKey(chrs)) count1[chrs]++;
                else count1[chrs] = 1;
            }
            int need = count1.Count;
            for (int i = 0; i < s2.Length; i++)
            {
                Dictionary<char, int> count2 = new();
                int current = 0;
                for (int j = 0; j < s2.Length; j++)
                {
                    char chrs = s2[j];
                    if (count1.ContainsKey(chrs)) count1[chrs]++;
                    else count1[chrs] = 1;

                    if (!count1.ContainsKey(chrs) || count1[chrs] < count2[chrs])
                    {
                        break;
                    }

                    if (count1[chrs] == count2[chrs])
                    {
                        current++;
                    }

                    if (current == need)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
