using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace AdvancedExam26June21
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ingr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] level = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> ingredients = new Queue<int>(ingr);
            Stack<int> levelOfFreshnes = new Stack<int>(level);
            Dictionary<int, string> dishes = new Dictionary<int, string>();
            dishes.Add(150, "Dipping sauce");
            dishes.Add(250, "Green salad");
            dishes.Add(300, "Chocolate cake");
            dishes.Add(400, "Lobster");
            Dictionary<string, int> cooked = new Dictionary<string, int>();
            //bool succeeded = false;
            while (ingredients.Count > 0 && levelOfFreshnes.Count > 0)
            {
                int currentIngredient = ingredients.Peek();
                if (currentIngredient == 0)
                {
                    ingredients.Dequeue();
                    continue;
                }
                
                int currenLEvelOfFreshnes = levelOfFreshnes.Peek();
                int freshnes = currentIngredient * currenLEvelOfFreshnes;
                if (dishes.ContainsKey(freshnes))
                {
                    string mealCooked = dishes[freshnes];
                    if (!cooked.ContainsKey(mealCooked))
                    {
                        cooked.Add(mealCooked, 1);
                    }
                    else
                    {
                        cooked[mealCooked] += 1;
                    }
                    ingredients.Dequeue();
                    levelOfFreshnes.Pop();
                }
                else
                {
                    levelOfFreshnes.Pop();
                    int newIngredient = ingredients.Dequeue() + 5;
                    ingredients.Enqueue(newIngredient);
                }
            }
            if (cooked.Count == 4)
            {
                Console.WriteLine("Applause! The judges are fascinated by your dishes!");
            }
            else
            {
                Console.WriteLine("You were voted off. Better luck next year.");
            }
            int ingerdientsLEft = 0;
            while (ingredients.Count > 0)
            {
                ingerdientsLEft += ingredients.Dequeue();
            }
            if (ingerdientsLEft != 0)
            {
                Console.WriteLine($"Ingredients left: {ingerdientsLEft}");
            }
            if (cooked.Count > 0)
            {
                foreach (var meal in cooked.OrderBy(x=> x.Key))
                {
                    Console.WriteLine($" # {meal.Key} --> {meal.Value}");
                }
            }
        }
    }
}
