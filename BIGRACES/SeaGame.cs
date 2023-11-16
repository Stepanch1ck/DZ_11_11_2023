using System;

namespace BIGRACES
{
    internal class SeaGame : Game
    {
        public int Score = 0;
        public SeaGame() : base("Море")
        {
        }
        public override void Print()
        {
            Console.WriteLine("Игра: Море");
            Console.WriteLine("Правила: Участники должны переплыть как можно дальше за 10 минут.");
        }

        public override int Play()
        {
            Random r = new Random();
            
            for (int i = 0; i < 10; i++)
            {
                int chance = r.Next(100);
                if (chance > 50)
                {
                    Score += 5;
                }
            }
            return Score;
        }
    }
}
