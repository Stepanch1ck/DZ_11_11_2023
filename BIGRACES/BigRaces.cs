using System;
using System.Collections.Generic;

namespace BIGRACES
{
    internal class BigRaces
    {
        private readonly List<Team> teams = new List<Team>();

        public BigRaces()
        {
            teams.Add(new Team("Россия", 15));
            teams.Add(new Team("Франция", 15));
            teams.Add(new Team("Китай", 15));
            teams.Add(new Team("Казахстан", 15));

        }

        
        
        public void Play(List<Game> games)
        {
            Random random = new Random();
            foreach (var team in teams)
            {
                foreach (var game in games)
                {

                    int score = game.Play() ;
                    team.AddScore(score);
                }
            }
            
            
            Dictionary<string, int> scores = new Dictionary<string, int>();
            foreach (var team in teams)
            {
                scores[team.Name] = team.Score;
            }
            List<Team> winners = new List<Team>();
            int maxScore = 0;
            foreach (var team in teams)
            {
                if (team.Score > maxScore)
                {
                    maxScore = team.Score;
                    winners.Clear();
                    winners.Add(team);
                }
                else if (team.Score == maxScore)
                {
                    winners.Add(team);
                }
            }
            Console.WriteLine("Итоги соревнований:");
            foreach (var team in teams)
            {
                Console.WriteLine("{0}: {1}", team.Name, team.Score);
            }
            Console.WriteLine("Победители:");
            foreach (var team in winners)
            {
                Console.WriteLine("{0}", team.Name);
            }
        }
    }
}
