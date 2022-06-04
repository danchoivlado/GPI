using Draw.src.Model.Contractors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw.src.Model
{
    public class RectangleShape : IShape
    {

        public RectangleF Rectangle { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public PointF Location { get; set; }
        public Color FillColor { get; set; }
        public string Name { get; set; }
        public Color BorderColor { get; set; }
        public int Opacity { get; set; }
        public float BorderWidth { get; set; }
        public float Angle { get; set; }

        public RectangleShape(RectangleF rectangle)
        {
            this.Rectangle = rectangle;
        }

        public void DrawSelf(Graphics grfx)
        {
            RotateShape(grfx);

            grfx.FillRectangle(new SolidBrush(Color.FromArgb(Opacity, FillColor)), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
            grfx.DrawRectangle(new Pen(BorderColor, BorderWidth), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
            grfx.ResetTransform();

        }

        public virtual void RotateShape(Graphics grfx)
        {

            grfx.TranslateTransform(Rectangle.X + Rectangle.Width / 2, Rectangle.Y + Rectangle.Height / 2);
            grfx.RotateTransform(Angle);

            grfx.TranslateTransform(-(Rectangle.X + Rectangle.Width / 2), -(Rectangle.Y + Rectangle.Height / 2));

        }
    }
}
