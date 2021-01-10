using System;
using System.Collections.Generic;
using System.Linq;

namespace SetCover
{
    class SetCover
    {
        static void Main(string[] args)
        {
            int[] universe = new[] { 1, 2, 3, 4, 5 };
            int[][] sets = new[]
            {
                new[] { 1 },
                new[] { 2, 4 },
                new[] { 5 },
                new[] { 3 }
               
            };

            List<int[]> selectedSets = ChooseSets(sets.ToList(), universe.ToList());
            Console.WriteLine($"Sets to take ({selectedSets.Count}):");

            foreach (int[] set in selectedSets)
            {
                Console.WriteLine($"{{ {string.Join(", ", set)} }}");
            }
        }

        public static List<int[]> ChooseSets(IList<int[]> sets, IList<int> universe)
        {
            List<int[]> result = new List<int[]>();
            sets = sets.OrderByDescending(x => x.Length).ToList();
            int index = 0;
            while (universe.Count > 0)
            {
                int[] currentSet = sets[index];
                for (int i = 0; i < currentSet.Length; i++)
                {
                    universe.Remove(currentSet[i]);
                }
                result.Add(currentSet);
                index++;
            }

            return result;


        }
    }
}
