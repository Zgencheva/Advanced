using System;
using System.Collections.Generic;
using System.Linq;

public class SumOfCoins
{
    public static void Main(string[] args)
    {
        var availableCoins = new[] { 1, 2, 5, 10, 20, 50 };
        var targetSum = 923;

        var selectedCoins = ChooseCoins(availableCoins, targetSum);

        Console.WriteLine($"Number of coins to take: {selectedCoins.Values.Sum()}");
        foreach (var selectedCoin in selectedCoins)
        {
            Console.WriteLine($"{selectedCoin.Value} coin(s) with value {selectedCoin.Key}");
        }
    }

    public static Dictionary<int, int> ChooseCoins(IList<int> coins, int targetSum)
    {
        Dictionary<int, int> result = new Dictionary<int, int>();
        int numbersOfCoins = 0;
        int index = 0;
        //ordering in descending order
        coins = coins.OrderByDescending(x => x).ToList();
        while (true)
        {
            if (targetSum == 0)
            {
                break;
            }
            while (targetSum >= coins[index])
            {
                if (!result.ContainsKey(coins[index]))
                {
                    result.Add(coins[index], 0);
                }
                result[coins[index]]++;
                targetSum -= coins[index];
                numbersOfCoins++;
            }
            index++;
            if (index == coins.Count)
            {
                break;
            }



        }
        //Console.WriteLine($"Number of coins to take: {numbersOfCoins}");
        return result;
    }
}