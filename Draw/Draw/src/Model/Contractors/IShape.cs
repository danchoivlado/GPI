using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw.src.Model.Contractors
{
    public interface IShape
    {
        RectangleF Rectangle { get; set; }
        float Width { get; set; }
        float Height { get; set; }
        PointF Location { get; set; }
        Color FillColor { get; set; }
        string Name { get; set; }
        Color BorderColor { get; set; }
        int Opacity { get; set; }
        float BorderWidth { get; set; }
        float Angle { get; set; }

        void DrawSelf(Graphics grfx);
        void RotateShape(Graphics grfx);
    }
}
