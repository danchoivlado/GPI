using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPIApp.Server
{
    public class RectangleShape : Shape
    {
        public RectangleShape(RectangleF rectangle) : base(rectangle)
        {

        }

        public override void DrawSelf(Graphics grfx)
        {
            grfx.FillRectangle(new SolidBrush(Color.FromArgb(Opacity, FillColor)), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
            grfx.DrawRectangle(new Pen(BorderColor, BorderWidth), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
            grfx.ResetTransform();
        }
    }
}
