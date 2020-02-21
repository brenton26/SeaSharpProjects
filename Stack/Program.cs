using System;
using System.Collections.Generic;

namespace StackNameSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();
            string userInput;
            bool isMenuRunning = true;

            while (isMenuRunning)
            {
                DisplayMenu();
                userInput = Console.ReadLine();
                isMenuRunning = PerformStackOperations(stack, userInput, isMenuRunning);

            }
        }
        private static bool PerformStackOperations(Stack stack, string userInput, bool isMenuRunning)
        {
            switch (userInput)
            {
                case "1":
                    Console.Write($"{Environment.NewLine}Input an element to add to the stack: ");
                    object newElement = (object)Console.ReadLine();
                    stack.Push(newElement);
                    Console.WriteLine($"The element \"{newElement.ToString()}\" was added successfully!");
                    Console.WriteLine($"There are now {stack.Count} elements in the stack.");
                    Console.WriteLine();
                    break;
                case "2":
                    Console.WriteLine($"{Environment.NewLine}Element {stack.Pop()} was removed from the stack!");
                    Console.WriteLine($"There are now {stack.Count} elements in the stack.");
                    Console.WriteLine();
                    break;
                case "3":
                    Console.WriteLine();
                    stack.ShowElements();
                    Console.WriteLine($"There are {stack.Count} elements in the stack.");
                    Console.WriteLine();
                    break;
                case "4":
                    Console.WriteLine();
                    stack.Clear();
                    Console.WriteLine("The stack was cleard of its elements!");
                    Console.WriteLine();
                    break;
                case "5":
                    isMenuRunning = false;
                    break;
                default:
                    Console.WriteLine($"{Environment.NewLine}Invalid option! Please choose and item from the menu.{Environment.NewLine}");
                    break;

            }
            return isMenuRunning;
        }

        private static void DisplayMenu()
        {
            Console.Write("Main Menu: ");
            Console.Write($"{Environment.NewLine}  1.Push to stack.");
            Console.Write($"{Environment.NewLine}  2.Pop from stack.");
            Console.Write($"{Environment.NewLine}  3.Display stack.");
            Console.Write($"{Environment.NewLine}  4.Clear stack of elements.");
            Console.Write($"{Environment.NewLine}  5.Exit application.");
            Console.Write($"{Environment.NewLine}  \x21AA Your option: ");
        }
    }

    class Stack
    {
        private List<object> _stack;

        public Stack()
        {
            this._stack = new List<object>();
        }
        public int Count
        {
            get { return _stack.Count; }
        }
        public void Push(object obj)
        {
            if (obj is null)
            {
                throw new InvalidOperationException();
            }
            else this._stack.Add(obj);
        }
        public object Pop()
        {
            if (_stack.Count == 0)
            {
                throw new InvalidOperationException();
            }
            else
            {
                object tempvar = this._stack[_stack.Count - 1];
                this._stack.RemoveAt(_stack.Count - 1);
                return tempvar;
            }
            
        }
        public void Clear()
        {
            this._stack.Clear();
        }
        public void ShowElements()
        {
            foreach (object item in this._stack)
            {
                Console.WriteLine(item);
            }            
        }
    }
}
