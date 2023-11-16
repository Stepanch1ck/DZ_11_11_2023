

using System;

namespace BIGRACES
{
    internal abstract class Game
    {
        protected string name;

        public Game(string name)
        {
            this.name = name;
        }

        public abstract int Play();
        public abstract void Print();
        
    }
}
