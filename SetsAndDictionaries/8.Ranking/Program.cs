using System;
using System.Collections.Generic;
using System.Linq;

namespace _8.Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> candidates = new Dictionary<string, Dictionary<string, int>>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end of contests")
                {
                    break;
                }
                var tokens = command.Split(':').ToArray();
                string contest = tokens[0];
                string pass = tokens[1];
                if (!contests.ContainsKey(contest))
                {

                    contests.Add(contest, pass);
                }
            }

            while (true)
            {
                string command = Console.ReadLine();
                bool isThePassValid = false;
                if (command == "end of submissions")
                {
                    break;
                }
                var tokens = command.Split("=>").ToArray();
                string contest = tokens[0];
                string pass = tokens[1];
                string candidate = tokens[2];
                int points = int.Parse(tokens[3]);
                if (contests.ContainsKey(contest))
                {
                    if (contests[contest] == pass)
                    {
                        isThePassValid = true;
                    }
                }
                if (isThePassValid)
                {
                    if (!candidates.ContainsKey(candidate))
                    {
                        candidates.Add(candidate, new Dictionary<string, int>());
                    }
                    if (!candidates[candidate].ContainsKey(contest))
                    {
                        candidates[candidate].Add(contest, 0);
                    }
                    if (candidates[candidate][contest] < points)
                    {
                        candidates[candidate][contest] = points;
                    }
                }

            }

            var bestCandidate = candidates.OrderByDescending(x => x.Value.Values.Sum()).First().Key;
           
            Console.WriteLine($"Best candidate is {bestCandidate} with total {candidates[bestCandidate].Values.Sum()} points.");
            Console.WriteLine("Ranking:");
            foreach (var item in candidates.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}");
                foreach (var contest in item.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }
}
