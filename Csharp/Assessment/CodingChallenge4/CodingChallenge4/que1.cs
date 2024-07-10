using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge4
{
    class que1
    {
        public static void Appendfilefunction()
        {
            FileStream file = new FileStream(@"D:\Trainning_matarial\Csharp\Assessment\CodingChallenge4\Newtext.txt", FileMode.Append,FileAccess.Write);
            StreamWriter writer = new StreamWriter(file);

            Console.Write("Enter the text that you want to append to the file : ");
            string txtappend = Console.ReadLine();

            writer.WriteLine(txtappend);
            writer.Flush();
            writer.Close();
            file.Close();
            Console.WriteLine("Text Appended sucessfully");

        }
    }
}
