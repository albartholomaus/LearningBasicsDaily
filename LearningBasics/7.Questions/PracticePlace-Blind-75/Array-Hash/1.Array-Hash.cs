using LearningBasics.Patterns.Creational.Builder.Product;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LearningBasics.PracticePlace
{
    public class Solution
    {
        public Solution()
        {
            //int[] nums = [1, 2, 2, 3, 3, 3];
            string[] strs = { "eats", "A", "lot", "of", "food" };
            Encode(strs);


        }
        public bool HasDuplicate(int[] nums)
        {
            return new HashSet<int>(nums).Count < nums.Length;
        }
        public bool IsAnagram(string s, string t)
        {
            Dictionary<char, int> hashTableS = new();
            Dictionary<char, int> hashTableT = new();

            Add(s, hashTableS);
            Add(t, hashTableT);

            foreach (var key in hashTableS)
            {
                if (!hashTableT.Contains(key))
                {
                    return false;
                }
            }

            return true;
        }

        public void Add(string s, Dictionary<char, int> HashTable)
        {
            foreach (char charter in s)
            {
                if (HashTable.ContainsKey(charter))
                {
                    int value = HashTable[charter];
                    HashTable[charter] = value + 1;
                }
                else
                {
                    HashTable.Add(charter, +1);
                }

            }
        }
        public bool IsAnagramOped(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            char[] sSort = s.ToCharArray();
            char[] tSort = t.ToCharArray();
            Array.Sort(sSort);
            Array.Sort(tSort);
            return sSort.SequenceEqual(tSort);
        }

        public int[] TwoSumBF(int[] nums, int target)
        {
            int[] returnIndexArray = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {

                        return new int[] { i, j };
                    }
                }
            }
            return returnIndexArray;
        }

        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> prevMap = new();

            for (int i = 0; i < nums.Length; i++)
            {
                var diff = target - nums[i];
                if (prevMap.ContainsKey(diff))
                {
                    return new int[] { prevMap[diff], i };
                }
                //prevMap[nums[i]]== the key that we want to store , =i is the value 
                prevMap[nums[i]] = i;
            }
            return null;
        }

        public List<List<string>> GroupAnagrams(string[] strs)
        {
            var res = new Dictionary<int, List<string>>();
            foreach (var s in strs)
            {
                int count = 0;
                //int[] count = new int[26];
                foreach (char c in s)
                {
                    count += Convert.ToInt32(c);
                    //  count[c - 'a']++;
                }
                int key = count;
                //string key = string.Join(",", count);
                if (!res.ContainsKey(key))
                {
                    res[key] = new List<string>();
                }
                res[key].Add(s);
            }
            return res.Values.ToList<List<string>>();
        }

        public int[] TopKFrequent(int[] nums, int k)
        {
            //nums = [1,2,2,3,3,3],  k = 2
            Dictionary<int, int> freqNumbers = new();

            foreach (int num in nums)
            {
                if (!freqNumbers.ContainsKey(num))
                {
                    freqNumbers[num] = 0;
                }
                freqNumbers[num]++;
            }
            var topK = freqNumbers.OrderByDescending(pair => pair.Value).Take(k).Select(pair => pair.Key).ToArray();

            return topK;
        }
        public string Encode(IList<string> strs)
        {
            string res = "";
            foreach (var str in strs)
            {
                int count = str.Length;
                res += count.ToString() + '#' + str;
            }

            Decode(res);
            return res;
        }
        public List<string> Decode(string s)
        {
            List<string> decoded = new List<string>();
            //A pointer that tracks where to start reading in the string.
            int iStartingIndex = 0;
            while (iStartingIndex < s.Length)
            {
                //jLastIndex starts at iStartingIndex and increments until it finds #.
                int jLastIndex = iStartingIndex;
                //Finds the position of the # separator, which indicates the end of the length marker.
                while (s[jLastIndex] != '#')
                {
                    jLastIndex++;
                }
                int length = (int)char.GetNumericValue(s[iStartingIndex]);
                //Moves iStartingIndex to the start of the actual substring.
                iStartingIndex = jLastIndex + 1;
                //jLastIndex now points to the end of the substring.
                jLastIndex = iStartingIndex + length;

                decoded.Add(s.Substring(iStartingIndex, length));
                //oves iStartingIndex to process the next encoded substring.
                iStartingIndex = jLastIndex;
            }
            return decoded;
        }

        public int PivotIndex(int[] nums)

        //724. Find Pivot Index
        //Given an array of integers nums, calculate the pivot index of this array.

        //The pivot index is the index where the sum of all the numbers strictly to the left of the index is equal to the sum of all the numbers strictly to the index's right.

        //If the index is on the left edge of the array, then the left sum is 0 because there are no elements to the left. This also applies to the right edge of the array.

        //Return the leftmost pivot index.If no such index exists, return -1.

        {//nums = [1,7,3,6,5,6]
            int total = 0;
            int leftNumber = 0;
            foreach (var number in nums)
            {
                total += number;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (leftNumber == total - nums[i] - leftNumber)
                {
                    return i;
                }
                leftNumber += nums[i];
            }
            return -1;
        }

        public int[] ProductExceptSelf(int[] nums)
        {
            //Given an integer array nums, return an array output where output[i] is the product of all the elements of nums except nums[i].
            //Input: nums = [1,2,4,6]


            int[] result = new int[nums.Length];
            //so the math works
            Array.Fill(result, 1);
            //Compute Prefix Products
            //we skip one because we dont need to do an computing he the skip, even if the number is higher then one, nothing is before the first index or index[0];
            for (int i = 1; i < nums.Length; i++)
            {
                //because we start at one we need to time the number in the result, as we pr filled the number its 1 , so the first  would be 1*1, then 1*2, then 2*3would be in the last stop[
                result[i] = result[i - 1] * nums[i - 1];
            }
            //here is our variable to be used later.setting it to 1 os the math works.  
            int postfix = 1;
            //starting from the back, then decrementing one at a time. 
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                //this is the computation for the out put, taking the post fix variable and the number in the result and timing it to the number. 
                result[i] *= postfix;
                //updating the variable postfix as we can then times the prefix 
                postfix *= nums[i];
            }
            return result;
        }
        public int[] ProductExceptSelfP(int[] nums)
        {

            //Given an integer array nums, return an array output where output[i] is the product of all the elements of nums except nums[i].
            //Input: nums = [1,2,4,6]

            int[] resultArray = new int[nums.Length];
            Array.Fill(resultArray, 1);
            for (int i = 1; i < nums.Length; i++)
            {
                resultArray[i] = resultArray[i - 1] * nums[i - 1];
            }
            int postfix = 1;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                resultArray[i] *= postfix;
                postfix *= nums[i];
            }
            return resultArray;
        }

        public static bool IsValidSudoku(char[][] board)
        {
            Dictionary<int, HashSet<char>> cols = new();
            Dictionary<int, HashSet<char>> rows = new();
            Dictionary<string, HashSet<char>> sqr = new();

            for (int r = 0; r < 9; r++)
            {
                for (int c = 0; c < 9; c++)
                {
                    if (board[r][c] == '.' || board[r][c] == ' ') continue;

                    string squareKey = (r / 3) + "," + (c / 3);
                    //this means that the key == what row or col, after the && means do we have the number and if they match then it is not valid. in basic , in that row , col or block and have that number its false 
                    if ((rows.ContainsKey(r) && rows[r].Contains(board[r][c])) ||
                        (cols.ContainsKey(c) && cols[c].Contains(board[r][c])) ||
                        (sqr.ContainsKey(squareKey) && sqr[squareKey].Contains(board[r][c])))
                    {
                        return false;
                    }
                    //if we DONT have it, add the key 
                    if (!rows.ContainsKey(r)) rows[r] = new();
                    if (!cols.ContainsKey(c)) cols[c] = new();
                    if (!sqr.ContainsKey(squareKey)) sqr[squareKey] = new();

                    //add the number
                    rows[r].Add(board[r][c]);
                    cols[c].Add(board[r][c]);
                    sqr[squareKey].Add(board[r][c]);

                }
            }
            return true;
        }
        public static int LongestConsecutive(int[] nums)
        {// [2,20,4,10,3,4,5]
            HashSet<int> numSet = new(nums);
            int longest = 0;
            foreach (var num in numSet)
            {
                if (!numSet.Contains(num - 1))
                {
                    int length = 1;
                    while (numSet.Contains(num + length))
                    {
                        length++;
                    }
                    longest = Math.Max(longest, length);
                }
            }

            return longest;
        }
        public static int LongestConsecutiveInArow(int[] nums)
        {
            ///not what I was thinking. 
            int longest = 1;

            for (int R = 0; R < nums.Length-1; R++)
            {

                if (nums[R] + 1 == nums[R + 1])
                {
                    longest++;
                }

            }
            return longest;
        }

    }
}