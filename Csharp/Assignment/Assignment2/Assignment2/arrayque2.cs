using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class arrayque2
    {
        public static void arrque2()
        {
            int[] arr = new int[10];
            Console.WriteLine("Enter marks of 10 students");
            for(int i=0;i<10;i++)
            {
                Console.Write($"Enter marks of student {i + 1} : ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            int total = arr.Sum();
            double avg = arr.Average();
            int min = arr.Min();
            int max = arr.Max();
            Console.WriteLine("The total marks of 10 students are : "+total);
            Console.WriteLine("The average marks of 10 students are : " + avg);
            Console.WriteLine("The minimum marks among 10 students is : " + min);
            Console.WriteLine("The maximum marks among 10 students is : " + max);
            Array.Sort(arr);
            Console.WriteLine("The marks of 10 students in ascending order are : ");
            foreach(int j in arr)
            {
                Console.Write(j+"\t");
            }
            Console.WriteLine();
            Array.Reverse(arr);
            Console.WriteLine("The marks of 10 students in descending order are : ");
            foreach (int k in arr)
            {
                Console.Write(k + "\t");
            }
            Console.Read();
        }
    }
}
