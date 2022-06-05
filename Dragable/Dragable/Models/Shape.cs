using System;
using System.Collections.Generic;
using System.Drawing;

namespace Dragable.Models
{

    [Serializable]

    public abstract class Shape
    {
        private RectangleF rectangle;
        public virtual RectangleF Rectangle
        {
            get { return rectangle; }
            set { rectangle = value; }
        }

        public virtual float Width
        {
            get { return Rectangle.Width; }
            set { rectangle.Width = value; }
        }

        public virtual float Height
        {
            get { return Rectangle.Height; }
            set { rectangle.Height = value; }
        }

        public virtual PointF Location
        {
            get { return Rectangle.Location; }
            set { rectangle.Location = value; }
        }

        private Color fillColor;
        public virtual Color FillColor
        {
            get { return fillColor; }
            set { fillColor = value; }
        }

        private string name;
        public virtual string Name
        {
            get { return name; }
            set { name = value; }
        }

        private Color borderColor;
        public virtual Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; }
        }

        private int opacity;
        public virtual int Opacity
        {
            get { return opacity; }
            set { opacity = value; }
        }

        private float borderWidth;
        public virtual float BorderWidth
        {
            get { return borderWidth; }
            set { borderWidth = value; }
        }

        private float angle;
        public virtual float Angle
        {
            get { return angle; }
            set { angle = value; }
        }

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

        public virtual void Move(float dx, float dy)
        {
            Location = new PointF(Location.X + dx, Location.Y + dy);

        }
    }
}
