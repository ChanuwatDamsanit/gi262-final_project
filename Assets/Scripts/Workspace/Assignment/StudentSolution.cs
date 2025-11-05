using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;
using Debug = AssignmentSystem.Services.AssignmentDebugConsole;

namespace Assignment
{
    public class StudentSolution : IAssignment
    {
        class Action
        {
            public string Name;
            public int Value;
        }

        #region Lecture

        public void LCT01_StackSyntax()
        {
            //O(1)
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Debug.Log($"Count: {stack.Count}");

            var top = stack.Pop();
            Debug.Log($"Popped: {top}");

            var peeked = stack.Peek();
            Debug.Log($"Peek: {peeked}");
            Debug.Log($"Count after peek: {stack.Count}");

           /* while (stack.Count > 0)
            {
                stack.Pop();
            }
            stack.Clear();*/ //O(n)
        }

        public void LCT02_QueueSyntax()
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            Debug.Log($"Count: {q.Count}");

            var front = q.Dequeue();
            Debug.Log($"Dequeue: {front}");

            var peeked = q.Peek();
            Debug.Log($"Peek: {peeked}");
            Debug.Log($"Count after dequeue: {q.Count}");

            while (q.Count > 0)
            {
                q.Dequeue();
            }
            q.Clear();
        }

        public void LCT03_ActionStack()
        {
            Action action1 = new Action { Name = "Action 1" };
            Action action2 = new Action { Name = "Action 2" };
            Action action3 = new Action { Name = "Action 3" };
            
            Stack<Action> stack = new Stack<Action>();
            stack.Push(action1);
            stack.Push(action2);
            stack.Push(action3);

            Debug.Log($"Executing {stack.Pop().Name}");
            Debug.Log($"Executing {stack.Pop().Name}");
            Debug.Log($"Executing {stack.Pop().Name}");

            /*while (stack.Count > 0)
            {
                var top = stack.Pop().Name;
                Debug.Log($"Executing {top}");
            }*/
        }

        public void LCT04_ActionQueue()
        {
            Action action1 = new Action { Name = "Action 1" };
            Action action2 = new Action { Name = "Action 2" };
            Action action3 = new Action { Name = "Action 3" };
            
            Queue<Action> q = new Queue<Action>();
            q.Enqueue(action1);
            q.Enqueue(action2);
            q.Enqueue(action3);

            Debug.Log($"Executing {q.Dequeue().Name}");
            Debug.Log($"Executing {q.Dequeue().Name}");
            Debug.Log($"Executing {q.Dequeue().Name}");

            /*while (q.Count > 0)
            {
                var first = q.Dequeue().Name;
                Debug.Log($"Executing {first}");
            }*/
        }

        #endregion

        #region Assignment

        public void ASN01_ReverseString(string str)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in str)
            {
                stack.Push(c);
            }

            string reversedString = "";

            while (stack.Count > 0)
            {
                char c = stack.Pop();

                reversedString += c;
            }
            Debug.Log($"{reversedString}");
        }

        public void ASN02_StackPalindrome(string str)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in str)
            {
                stack.Push(c);
            }

            string reversedString = "";
            while (stack.Count > 0)
            {
                reversedString += stack.Pop();
            }

            bool isPalindrome = str.Equals(reversedString);
            string output = isPalindrome ? "is a palindrome" : "is not a palindrome";
            Debug.Log(output);
        }

        #endregion

        #region Extra

        public void EX01_ParenthesesChecker(string str)
        {

            Stack<char> stack = new Stack<char>();

            Dictionary<char, char> matchingPairs = new Dictionary<char, char>
        {
            { ')', '(' },
            { ']', '[' },
            { '}', '{' }
        };

            bool isBalanced = true;

            foreach (char c in str)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }
                else if (c == ')' || c == ']' || c == '}')
                {
                    if (stack.Count == 0)
                    {
                        isBalanced = false;
                        break;
                    }

                    char lastOpen = stack.Pop();

                    if (lastOpen != matchingPairs[c])
                    {
                        isBalanced = false;
                        break;
                    }
                }
            }

            if (isBalanced && stack.Count == 0)
            {
                Debug.Log("Balanced");
            }
            else
            {
                Debug.Log("Unbalanced");
            }
        }

        #endregion
    }
}
