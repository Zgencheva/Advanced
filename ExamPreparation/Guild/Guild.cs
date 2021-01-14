using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Guild
{
    public class Guild
    {
        public List<Player> Rooster { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count { get => this.Rooster.Count; }


        public Guild(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.Rooster = new List<Player>();
            
            
        }

        
        public void AddPlayer(Player player)
        {
            if (this.Rooster.Count < Capacity)
            {
                this.Rooster.Add(player);
            }
        }

        public bool RemovePlayer(string name)
        {
            //bool isRemoved = false;
            Player player = Rooster.Where(x => x.Name == name).FirstOrDefault();
            return this.Rooster.Remove(player);

        }

        public void PromotePlayer(string name)
        {
            Player player = Rooster.Where(x => x.Name == name).FirstOrDefault();
            if (player.Rank != "Member")
            {
                player.Rank = "Member";
            }
        }

        public void DemotePlayer(string name)
        {
            Player player = Rooster.Where(x => x.Name == name).FirstOrDefault();
            if (player.Rank != "Trial")
            {
                player.Rank = "Trial";
            }
        }
        public Player[] KickPlayersByClass(string cl)
        {
            List<Player> removed = new List<Player>();
            for (int i = 0; i < Rooster.Count; i++)
            {
                if (Rooster[i].Class == cl)
                {
                    removed.Add(Rooster[i]);

                }
            }

            foreach (Player player in removed)
            {
                Rooster.Remove(player);
            }

            return removed.ToArray();
        }   

        
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Players in the guild: {this.Name}");
            foreach (Player player  in this.Rooster)
            {
                sb.AppendLine(player.ToString());
            }
            return sb.ToString().TrimEnd();
        }




    }
}
