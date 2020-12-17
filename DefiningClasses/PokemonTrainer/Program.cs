using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace PokemonTrainer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Trainer> trainers = new List<Trainer>();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Tournament")
                {
                    break;
                }
                string[] tokens = command.Split();
                string trainerName = tokens[0];
                Pokemon currentPokemon = new Pokemon(tokens[1], tokens[2], int.Parse(tokens[3]));
                if (trainers.Any(x => x.Name ==trainerName) == true)
                {
                    Trainer currentTrainer = trainers.Where(x => x.Name == trainerName).FirstOrDefault();                  
                    currentTrainer.ACollectionOfPokemons.Add(currentPokemon);
                    
                }
                else
                {
                    Trainer currentTrainer = new Trainer(trainerName);
                    currentTrainer.ACollectionOfPokemons.Add(currentPokemon);
                    trainers.Add(currentTrainer);
                }

            }

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }
                foreach (Trainer item in trainers)
                {
                    if (item.ACollectionOfPokemons.Any(x => x.Element == command) == true)
                    {
                        item.NumberOfBadges++;
                    }
                    else
                    {
                        List<Pokemon> pokemonsToBeDeleted = new List<Pokemon>();
                        foreach (Pokemon pokemon in item.ACollectionOfPokemons)
                        {
                            pokemon.Health -= 10;
                            if (pokemon.Health <= 0)
                            {
                                pokemonsToBeDeleted.Add(pokemon);
                            }
                            
                        }

                        foreach (Pokemon poke in pokemonsToBeDeleted)
                        {
                            item.ACollectionOfPokemons.Remove(poke);
                        }
                    }
                }

            }

            foreach (Trainer trainerCol in trainers.OrderByDescending(x=> x.NumberOfBadges))
            {
                Console.WriteLine($"{trainerCol.Name} {trainerCol.NumberOfBadges} {trainerCol.ACollectionOfPokemons.Count}");
            }
        }
    }
}
