using System;
using System.Collections.Generic;
using System.Text;

namespace Lists
{
    class ListsExercises
    {
        public static void Users()
        {
            var names = new List<string>();

            while (true)
            {
                Console.WriteLine("type a name: (or hit Enter to quit): ");

                var input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                    break;
                names.Add(input);
            }
            if (names.Count > 2)
                Console.WriteLine("{0}, {1} and {2} others like your post", names[0], names[1], names.Count - 2);
            else if (names.Count == 2)
                Console.WriteLine("{0} and {1} like your post", names[0], names[1]);
            else if (names.Count == 1)
                Console.WriteLine("{0} likes your post.", names[0]);
            else
                Console.WriteLine();
        }
    }
    }

