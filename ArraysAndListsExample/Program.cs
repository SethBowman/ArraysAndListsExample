using System.Collections.Generic;

namespace ArraysAndListsExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arrays
            //Arrays have a set size that cannot change
            var numbers = new int[] { 22, 40, 2, 15, 24 };

            numbers[0] = 100;
            //Arrays have a property called 'Length' that shows the number of things in the Array

            //Console.WriteLine(numbers.Length);

            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            Console.WriteLine();
            //Lists
            //Lists have a size that can change all you want
            var listNumbers = new List<int>() { 20, 100, 290, 3 };

            //Lists have a property called 'Count' that shows the number of things in the List
            //Console.WriteLine(listNumbers.Count);

            //listNumbers.Add(1000);
            //listNumbers.Remove(20);

            var names = new string[] { "Seth", "John", "Cruz" };

            //Console.WriteLine(names[2]);

            //names[0] = "Mack";

            //Console.WriteLine(names[0]);          
            

            var students = new List<string>();            

            students.Add("Mack");
            students.Add("Cali");

            foreach (var name in students)
            {
                Console.WriteLine(name);
            }



        }
    }
}