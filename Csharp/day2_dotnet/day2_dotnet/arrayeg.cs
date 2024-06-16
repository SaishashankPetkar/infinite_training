using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2_dotnet
{
    class arrayeg
    {
        public static void singledimension()
        {
            int[] arr = new int[] { 76, 4, 2, 3, 5 };
            Console.WriteLine(arr.Length);
            Console.WriteLine(arr.Rank);
            Console.WriteLine("=======Berfore sort=======");
            foreach(int x in arr)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("=======After sort=======");
            Array.Sort(arr);
            for(int i=0; i<arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("=======Array reverse=======");
            Array.Reverse(arr);
            foreach (int x in arr)
            {
                Console.WriteLine(x);
            }

            string[] str = new string[2] {"Hello", "world"};

            foreach(var s in str)
            {
                Console.WriteLine(s);
            }
        }

        public static void twodimension()
        {
            int[,] myarr = new int[2, 3] { { 1, 2, 3 },{4,5,6} };
            //1st loop iterates the rows
           // for(int i=0; i<2;i++) we cannot hardcode any part our app
           // //we will make use of getlength()
            for(int i=0;i<myarr.GetLength(0);i++)
            { 
                //2nd to iterate colums
                //for(int j=0;j<3;j++)
                for(int j=0;j<myarr.GetLength(1);j++)
                {
                    Console.Write(myarr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public static void jaagedarray()
        {
            //1.declar jagged array of 2 rows
            int[][] myjag = new int[2][]; //only no. of rows is specified , colums is empty

            //2.let us set the size for each row 
            myjag[0] = new int[3];
            myjag[1] = new int[2];

            //3. let us initialize the jagged array
            myjag[0][0] = 2;
            myjag[0][1] = 4;
            myjag[0][2] = 6;

            myjag[1][0] = 1;
            myjag[1][1] = 3;

            //another way to initialize jagged array
            int[][] jag2 =
            {
                new int[]{5,10,15,20},
                new int[]{25,30},
                new int[]{35,40,45}

            };

            //to diplay the elements of the above jagged array
            for(int i=0;i<jag2.Length;i++)
            {
                Console.WriteLine("Number of elements at row: " + i + "arr" + jag2[i].Length);

                //inner loop
                for(int j=0; j<jag2[i].Length;j++)
                {
                    Console.WriteLine(jag2[i][j] + " ");
                }
            }
        }
    }
}
