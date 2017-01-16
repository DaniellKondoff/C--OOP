using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FootballTeamGenerator
{
    
    public class Football
    {
       static Dictionary<string, Team> teams = new Dictionary<string, Team>();

       public static void Main(string[] args)
        {
            string line = Console.ReadLine();

            while(line != "END")
            {
                string[] tokens = line.Split(';');
                string cmd = tokens[0];

                try
                {
                    ProcessCommand(tokens, cmd);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                line = Console.ReadLine();
            }
        }

        private static void ProcessCommand(string[] tokens, string cmd)
        {
            switch (cmd)
            {
                case "Team":
                    CreateTeam(tokens[1]);
                    break;
                case "Add":
                    AddPlayerToTeam(
                        tokens[1],
                        tokens[2],
                        int.Parse(tokens[3]),
                        int.Parse(tokens[4]),
                        int.Parse(tokens[5]),
                        int.Parse(tokens[6]),
                        int.Parse(tokens[7]));
                    break;
                case "Remove":
                    RemovePlayerFromTeam(tokens[1], tokens[2]);
                    break;
                case "Rating":
                    GetRating(tokens[1]);
                    break;
                default:
                    break;
            }
        }

        private static void GetRating(string teamName)
        {
            EnsureTeamExist(teamName);

            Team team = teams[teamName];

            Console.WriteLine(team);
        }

        private static void RemovePlayerFromTeam(string teamName, string playerName)
        {
            EnsureTeamExist(teamName);
            Team team = teams[teamName];
            team.RemovePlayer(playerName);
        }

        

        private static void AddPlayerToTeam(string teamName, string playerName, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            EnsureTeamExist(teamName);

            Player player = new Player(
                playerName,
                new Stat("Endurance", endurance),
                new Stat("Sprint", sprint),
                new Stat("Dribble", dribble),
                new Stat("Passing", passing),
                new Stat("Shooting", shooting)
                );

            Team team = teams[teamName];
            team.AddPlayer(player);
        }

        private static void CreateTeam(string teamName)
        {
            Team team = new Team(teamName);
            teams.Add(teamName, team);
        }
        private static void EnsureTeamExist(string teamName)
        {
            if (!teams.ContainsKey(teamName))
            {
                throw new InvalidOperationException($"Team {teamName} does not exist.");
            }
        }
    }
}
