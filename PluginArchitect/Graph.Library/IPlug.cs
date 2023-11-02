using System.Drawing;

namespace Graph.Library
{
    public interface IPlug
    {
        string Name { get; }
        void Draw(Graphics graphics, SolidBrush solidBrush, int x, int y, int width, int height);
    }
}
