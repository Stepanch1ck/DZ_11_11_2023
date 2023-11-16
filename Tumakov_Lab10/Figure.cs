

namespace Tumakov_Lab10
{
    internal abstract class Figure : IFigure
    {
        protected string color;
        protected bool visible;

        public Figure(string color, bool visible)
        {
            this.color = color;
            this.visible = visible;
        }

        public abstract void MoveX(int dx);

        public abstract void MoveY(int dy);

        public abstract void SetColor(string color);

        public abstract void IsVisible(bool visible);

        public abstract void Print();
    }
}
