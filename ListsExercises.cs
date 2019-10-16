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
        }
    }
}
