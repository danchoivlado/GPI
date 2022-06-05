using System;
using System.Collections.Generic;
using System.Drawing;

namespace Dragable.Models
{

    [Serializable]

    public abstract class Shape
    {
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

        public Shape()
        {
        }

        public Shape(RectangleF rect)
        {
            Rectangle = rect;
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


        public virtual bool Contains(PointF point)
        {
            return Rectangle.Contains(point.X, point.Y);
        }

        public virtual void DrawSelf(Graphics grfx)
        {

        }
    }
}
