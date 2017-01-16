using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FootballTeamGenerator
{
    public class Team
    {
        private string name;
        private Dictionary<string, Player> players;
        private double rating;

        public Team(string name)
        {
            this.Name = name;
            this.players = new Dictionary<string, Player>();
            this.rating = 0.0;
        }
        public string Name
        {
            get { return this.name; }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException($"A {nameof(this.name)} should not be empty.");
                }

                this.name = value;
            }
        }

        public void AddPlayer(Player player)
        {
            this.rating += player.OveralSkill;
            this.players.Add(player.Name, player);
        }

        public void RemovePlayer(string playerName)
        {
            if (!this.players.ContainsKey(playerName))
            {
                throw new InvalidOperationException($"Player {playerName} is not in {this.Name} team.");
            }

            Player player = this.players[playerName];

            this.rating -= player.OveralSkill;
            this.players.Remove(player.Name);
        }

        public override string ToString()
        {
            string ressult = $"{this.Name} - {this.rating}";
            return ressult;

        }

    }
}
