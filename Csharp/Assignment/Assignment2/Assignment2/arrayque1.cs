using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class arrayque1
    {
        public static void arrque1()
        {
            Console.Write("Enter the size of array : ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int[] arr = new int[x];
            for(int i= 0; i<x; i++)
            {
                Console.Write($"Enter {i + 1} Element of array : ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            int max=arr.Max();
            double avg = arr.Average();
            Console.WriteLine();
            Console.WriteLine("The maximum value from entered array is : "+ max);
            Console.WriteLine("The average value of entred array is : " + avg);
            Console.Read();

        }
    }
}
