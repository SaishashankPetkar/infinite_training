using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class que1
    {
        public static void Squarefunc()
        {
            List<int> nums = new List<int>();
            Console.Write("Enter how many numbers square you want to find : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"Enter the {n} numbers whose square you want to find : ");
            for(int i = 0; i < n; i++)
            {
                Console.Write($"Enter {i+1} number whose square you want to find : ");
                int Num = Convert.ToInt32(Console.ReadLine());
                nums.Add(Num);
            }

            var result = nums.Where(x => x * x > 20)
                             .Select(x => new { nums = x, square = x * x });

            Console.WriteLine();
            Console.WriteLine("Numbers with there squares whose squares is greater than 20");
            foreach(var iteam in result)
            {
                Console.WriteLine($"Number : {iteam.nums} ---> Square : {iteam.square}");
            }
        }
    }
}
