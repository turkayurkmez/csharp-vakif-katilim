using Graph.Library;
using System.Drawing;

namespace Graph.Plugins
{
    public class Circle : IPlug
    {
        public string Name => "Daire";

        public void Draw(Graphics graphics, SolidBrush solidBrush, int x, int y, int width, int height)
        {
            graphics.FillEllipse(solidBrush, x, y, width, height);
        }
    }
}
