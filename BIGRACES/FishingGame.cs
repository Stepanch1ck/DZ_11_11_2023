using System;

namespace BIGRACES
{
    internal class FishingGame : Game
    {
        public int Score = 0;
        public FishingGame() : base("Рыбалка")
        {
        }
        public override void Print()
        {
            Console.WriteLine("Игра: Рыбалка");
            Console.WriteLine("Правила: Участники должны поймать как можно больше рыбы за 1 час.");
        }
        public override int Play()
        {
            Random r = new Random();
            
            for (int i = 0; i < 2600; i++)
            {
                int chance = r.Next(100);
                if (chance > 70)
                {
                    Score += 1;
                }
            }
            return Score;
        }
    }
}
