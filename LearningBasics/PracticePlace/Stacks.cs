using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.PracticePlace
{
    public class Stacks
    {
        public static bool IsValid(string s)
        {
            List<char> stack = new();

            foreach (var str in s)
            {
                if (str == '(' || str == '{' || str == '[')
                {
                    stack.Add(str);
                }
                else
                {
                    if (stack.Count <= 0) return false;
                    char poped = stack.Last();
                    stack.RemoveAt(stack.Count - 1);
                    string check = poped.ToString() + str.ToString();
                    if (check == "()" || check == "{}" || check == "[]")
                    {
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public bool IsValid1(string s)
        {// "([{}])"
            Stack<char> stack = new Stack<char>();
            Dictionary<char, char> closeToOpen = new Dictionary<char, char> {
            { ')', '(' },
            { ']', '[' },
            { '}', '{' }
        };

            foreach (char c in s)
            {
                if (closeToOpen.ContainsKey(c))
                {
                    var test = closeToOpen[c];
                    // closeToOpen[c] == c is  the key and then will return the value assigned to said key 

                    if (stack.Count > 0 && stack.Peek() == closeToOpen[c])
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    stack.Push(c);
                }
            }
            return stack.Count == 0;
        }

        Stack<int> stack;
        Stack<int> minStack;
        public Stacks()
        {
            stack = new();
            minStack = new();
        }
        public void Push(int val)
        {
            stack.Push(val);
            val = Math.Min(val, minStack.Count == 0 ? val : minStack.Peek());
            minStack.Push(val);
        }
        public void Pop()
        {
            stack.Pop();
            minStack.Pop();
        }
        public int Top()
        {
            return stack.Peek();
        }
        public int GetMin()
        {
            return minStack.Peek();
        }

        public static int EvalRPN(string[] tokens)
        {
            //tokens = ["1","2","+","3","*","4","-"]
            Stack<int> PolishNotation = new();
            foreach (var str in tokens)
            {
                if (int.TryParse(str, out int number))
                {
                    PolishNotation.Push(number);
                }
                else
                {
                    int first = PolishNotation.Pop();
                    int second = PolishNotation.Pop();
                    int pushInt = 0;
                    switch (str)
                    {
                        case "+": pushInt = second + first; break;
                        case "-": pushInt = second - first; break;
                        case "*": pushInt = second * first; break;
                        case "/": pushInt = second / first; break;
                        default: return PolishNotation.Peek();
                    }
                    PolishNotation.Push(pushInt);
                }
            }
            return PolishNotation.Peek();
        }
        public static int[] DailyTemperatures(int[] temperatures)
        {
            //temperatures = [30,38,30,36,35,40,28]
            Stack<int> stack = new();
            int[] output = new int[temperatures.Length];


            for (int i = 0; i < temperatures.Length; i++)
            {
                while (stack.Count > 0 && temperatures[i] > temperatures[stack.Peek()])
                {
                    int prevIndex = stack.Pop();
                    output[prevIndex] = i - prevIndex;
                }
                stack.Push(i);
            }
            return output;
        }

        public int CarFleet(int target, int[] position, int[] speed)
        {
            int[][] pair = new int[position.Length][];
            for (int i = 0; i < position.Length; i++)
            {
                pair[i] = new int[] { position[i], speed[i] };
            }
            Array.Sort(pair, (a, b) => b[0].CompareTo(a[0]));
            Stack<double> stack = new Stack<double>();
            foreach (var p in pair)
            {
                stack.Push((double)(target - p[0]) / p[1]);
                if (stack.Count >= 2 && stack.Peek() <= stack.ElementAt(1))
                {
                    stack.Pop();
                }

            }
            return stack.Count;
        }
    }
}


