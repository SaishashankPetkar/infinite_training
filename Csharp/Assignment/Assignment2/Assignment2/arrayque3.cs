using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class arrayque3
    {
        public static void arrque3()
        {
            Console.Write("The size of arrays whose elements you want to copy into one another : ");
            int x = int.Parse(Console.ReadLine());
            int[] arr1 = new int[x];
            int[] arr2 = new int[x];
            int[] temp = new int[x];
            Console.WriteLine();
            for(int i=0;i<x;i++)
            {
                Console.Write($"Enter {i + 1} element of array 1 : ");
                arr1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            for (int i = 0; i < x; i++)
            {
                Console.Write($"Enter {i + 1} element of array 2 : ");
                arr2[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Array 1 before copying is :");
            foreach(int i in arr1)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
            Console.WriteLine("Array 2 before copying is :");
            foreach (int i in arr2)
            {
                Console.Write(i + "\t");
            }
            for(int i=0;i<x;i++)
            {
                temp[i] = arr1[i];
            }
            for (int i = 0; i < x; i++)
            {
                arr1[i] = arr2[i];
            }
            for (int i = 0; i < x; i++)
            {
                arr2[i] = temp[i];
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Array 1 after copying is :");
            foreach (int i in arr1)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
            Console.WriteLine("Array 2 after copying is :");
            foreach (int i in arr2)
            {
                Console.Write(i + "\t");
            }
            Console.Read();
        }
    }
}
