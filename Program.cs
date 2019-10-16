using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
           /*
            * Some methods
            * Add()
            * AddRange()
            * Remove()
            * RemoveAt()
            * IndexOf()
            * Contains()
            * Count
            */

           var numbers = new List<int>(){1, 2, 3,4};
           numbers.Add(1);
           numbers.AddRange(new int[3]{5,6,7});
           foreach (var number in numbers)
               Console.WriteLine(number);

           Console.WriteLine("Index of 1 " +numbers.IndexOf(1));
           Console.WriteLine("Last Index of 1 " +numbers.LastIndexOf(1));
           Console.WriteLine("number of items in the list: " +numbers.Count);

            //remove item from a list
           for (var i = 0; i < numbers.Count; i++)
           {
               if (numbers[i] == 1)
                   numbers.Remove(numbers[i]);
           }
           foreach (var number in numbers)
                Console.WriteLine(number);
           //clearing the list
           numbers.Clear();
           Console.WriteLine("count: "+ numbers.Count);
        }
    }
}
