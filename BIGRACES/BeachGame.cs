using System;

namespace BIGRACES
{
    internal class BeachGame : Game
    {
        public int Score = 0;
        public BeachGame() : base("Пляж")
        {
        }
        public override void Print()
        {
            Console.WriteLine("Игра: Пляж");
            Console.WriteLine("Правила: Участники должны собрать как можно больше ракушек за 1 минуту.");
        }
        public override int Play()
        {
            Random r = new Random();
            for (int i = 0; i < 60; i++)
            {
                int chance = r.Next(100);
                if (chance > 50)
                {
                    Score += 1;
                }
            }
            return Score;
        }
    }
}
