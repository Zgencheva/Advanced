using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace IteratorsAndComparatorsTasks02
{
    class Program
    {
        static void Main(string[] args)
        {
            var customStack = new Stack<string>();

            var firstInput = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            for (int i = 1; i < firstInput.Length; i++)
            {
                customStack.Push(firstInput[i]);
            }

            var stackIEnum = new StackIEnum<string>(customStack);

            while (true)
            {
                var commandInput = Console.ReadLine();

                if (commandInput == "END")
                {
                    break;
                }

                if (commandInput == "Pop")
                {
                    stackIEnum.Pop(customStack);
                }
                else if (commandInput.Contains("Push"))
                {
                    var pushCommand = commandInput
                        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();

                    stackIEnum.Push(customStack, pushCommand[1]);
                }
            }

            foreach (var item in stackIEnum)
            {
                Console.WriteLine(item);
            }

            foreach (var item in stackIEnum)
            {
                Console.WriteLine(item);
            }

        }
    }
}
