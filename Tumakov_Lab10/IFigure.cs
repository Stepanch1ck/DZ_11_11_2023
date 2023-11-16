

namespace Tumakov_Lab10
{
    internal interface IFigure
    {
        void MoveX(int dx);

        void MoveY(int dy);

        void SetColor(string color);

        void IsVisible(bool visible);

        void Print();
    }
}
