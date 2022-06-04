using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPIApp.Server
{
    public abstract class Shape
    {
        public Shape(RectangleF rect)
        {
            this.Rectangle = rect;
        }

        public Shape(Shape shape)
        {
            this.Height = shape.Height;
            this.Width = shape.Width;
            this.Location = shape.Location;
            this.Rectangle = shape.Rectangle;

            this.FillColor = shape.FillColor;
            this.BorderWidth = shape.BorderWidth;
        }



        public virtual RectangleF Rectangle { get; set; }
        public virtual float Width { get; set; }
        public virtual float Height { get; set; }
        public virtual PointF Location { get; set; }
        public virtual Color FillColor { get; set; }
        public virtual string Name { get; set; }
        public virtual Color BorderColor { get; set; }
        public virtual int Opacity { get; set; }
        public virtual float BorderWidth { get; set; }
        public virtual float Angle { get; set; }

        public virtual void DrawSelf(Graphics grfx)
        {

        }
    }
}
