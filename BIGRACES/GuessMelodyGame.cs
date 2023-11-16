using System;
using System.Collections.Generic;


namespace BIGRACES
{
    internal class GuessMelodyGame : Game
    {
        private readonly List<string> melodies = new List<string>();
        public int Score = 0;

        public GuessMelodyGame() : base("Угадай мелодию")
        {
            melodies.Add("Happy Birthday");
            melodies.Add("Twinkle, Twinkle, Little Star");
            melodies.Add("Mary Had a Little Lamb");
            melodies.Add("Jingle Bells");
            melodies.Add("We Wish You a Merry Christmas");
        }
        public override void Print()
        {
            Console.WriteLine("Игра: Угадай мелодию");
            Console.WriteLine("Нужно за отведенное время угадать мелодию");
        }

        public override int Play()
        {
            Random r = new Random();
            foreach (var item in melodies)
            {
                int chance = r.Next(100);
                if (chance > 50)
                {
                    Score += 10;
                }
            }
            return Score; 
            
        }
    }
}
