using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge3
{
    class Cricket
    {
        public static void Pointscalculation(int no_of_matches)
        {
            int[] match_scores = new int[no_of_matches];

            for (int i = 0; i < no_of_matches; i++)
            {
                Console.Write($"Enter score of the team for match {i + 1}: ");
                match_scores[i] = int.Parse(Console.ReadLine());
            }

            int sum = match_scores.Sum();
            double avg = match_scores.Average();
            Console.WriteLine();
            Console.WriteLine($"Sum of scores for {no_of_matches} played by team is: {sum}");
            Console.WriteLine($"Average of scores for {no_of_matches} played by team is: {avg}");
        }
    }
    class que1
    {
        public static void cricketcalling()
        {
            Console.WriteLine("IPL Team Scores Details .");
            Console.WriteLine();
            Console.Write("Enter the Total Number of matches Played by the Team : ");
            int tot_matches = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Cricket.Pointscalculation(tot_matches);
        }
    }
}
