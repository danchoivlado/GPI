using Draw.src.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draw.src.Processors
{
    public class DisplayProcessor
    {
        public List<Shape> ShapeList { get; set; }

        public DisplayProcessor()
        {
            this.ShapeList = new List<Shape>();
        }

        public void ReDraw(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Draw(e.Graphics);
        }

        public virtual void Draw(Graphics grfx)
        {
            foreach (Shape item in ShapeList)
            {
                DrawShape(grfx, item);
            }
        }

        public virtual void DrawShape(Graphics grfx, Shape item)
        {
            item.DrawSelf(grfx);
        }



    }
}
