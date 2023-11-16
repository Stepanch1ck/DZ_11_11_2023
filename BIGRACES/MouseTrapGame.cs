using System;

namespace BIGRACES
{
    internal class MouseTrapGame : Game
    {
        public int Score = 0;
        public MouseTrapGame() : base("Мышеловка")
        {
        }
        public override void Print()
        {
            Console.WriteLine("Игра: Мышеловка");
            Console.WriteLine("Правила: Участники должны поймать как можно больше мышей за 5 минут.");
        }

        public override int Play()
        {
            Random r = new Random();
            
            for (int i = 0; i < 5; i++)
            {
                int chance = r.Next(100);
                if (chance > 50)
                {
                    Score += 15;
                }
            }
            return Score;
        }
    }
}
