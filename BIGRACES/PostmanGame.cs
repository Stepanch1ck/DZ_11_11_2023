using System;

namespace BIGRACES
{
    internal class PostmanGame : Game
    {
        public int Score = 0;
        public PostmanGame() : base("Почтальоны")
        {
        }
        public override void Print()
        {
            Console.WriteLine("Игра: Почтальоны");
            Console.WriteLine("Правила: Участники должны доставить как можно больше писем за 2 часа.");
        }
        public override int Play()
        {
            Random r = new Random();
            
            for (int i = 0; i < 120; i++)
            {
                int chance = r.Next(100);
                if (chance > 50)
                {
                    Score += 2;
                }
            }
            return Score;
        }
    }
}
