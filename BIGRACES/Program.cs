using System;
using System.Collections.Generic;

namespace BIGRACES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("шоу Большие гонки");
            
            List<Game> games = new List<Game>();
            games.Add(new BeachGame());
            games.Add(new MouseTrapGame());
            games.Add(new SeaGame());
            games.Add(new FishingGame());
            games.Add(new PostmanGame());
            games.Add(new GuessMelodyGame());
            BigRaces bigRaces = new BigRaces();
            bigRaces.Play(games);
            Console.WriteLine("Нажмите Enter");
            Console.ReadKey();
        }
    }
}
