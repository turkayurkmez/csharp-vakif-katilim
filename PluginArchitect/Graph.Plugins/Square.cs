using Graph.Library;
using System.Drawing;

namespace Graph.Plugins
{
    public class Square : IPlug
    {
        public string Name => "Kare";

        public void Draw(Graphics graphics, SolidBrush solidBrush, int x, int y, int width, int height)
        {
            graphics.FillRectangle(solidBrush, x, y, width, height);
        }
    }
}