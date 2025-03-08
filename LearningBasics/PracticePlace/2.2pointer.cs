using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.Intrinsics.X86;
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

                if (numbers[leftPointer] + numbers[rightPointer] > target)
                {
                    rightPointer--;
                }
                else if (numbers[leftPointer] + numbers[rightPointer] < target)
                {
                    leftPointer++;
                }

                if (numbers[leftPointer] + numbers[rightPointer] == target)
                {
                    return new int[] { leftPointer + 1, rightPointer + 1 };
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

    }
}
