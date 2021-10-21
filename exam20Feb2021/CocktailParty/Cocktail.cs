using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CocktailParty
{
    public class Cocktail
    {
        public Cocktail(string name, int capacity, int maxAlcoholLevel)
        {
            Name = name;
            Capacity = capacity;
            MaxAlcoholLevel = maxAlcoholLevel;
            this.Ingredients = new List<Ingredient>();
        }

        public List<Ingredient> Ingredients { get; private set; }
        public string Name { get; private set; }
        public int Capacity { get; private set; }
        public int MaxAlcoholLevel { get; private set; }

        public int CurrentAlcoholLevel => this.Ingredients.Sum(x => x.Alcohol);

        public void Add(Ingredient ingredient)
        {

            if (this.Capacity > this.Ingredients.Count)
            {
                if (this.CurrentAlcoholLevel + ingredient.Alcohol <= MaxAlcoholLevel)
                {
                    if (this.Ingredients.Any(x => x.Name == ingredient.Name))
                    {

                    }
                    else
                    {
                        Ingredients.Add(ingredient);
                    }



                }


            }
        }

        public bool Remove(string name)
        {

            Ingredient current = Ingredients.FirstOrDefault(x => x.Name == name);
            return Ingredients.Remove(current);

            


        }

        public Ingredient FindIngredient(string name)
        {

            return Ingredients.FirstOrDefault(x => x.Name == name);



        }

        public Ingredient GetMostAlcoholicIngredient()
        {

            return Ingredients.OrderByDescending(x => x.Alcohol).FirstOrDefault();



        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cocktail: {this.Name} - Current Alcohol Level: {CurrentAlcoholLevel}");
            foreach (Ingredient ingr in Ingredients)
            {
                sb.AppendLine(ingr.ToString());
            }
           
            return sb.ToString().TrimEnd();
        }


    }
}