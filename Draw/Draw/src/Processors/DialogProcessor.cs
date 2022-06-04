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
    public class DialogProcessor
    {
        public List<RectangleShape> RectangleList { get; set; }


        public DialogProcessor()
        {
            this.Selection = new List<Shape>();
            this.RectangleList = new List<RectangleShape>();
        }

        public List<Shape> Selection { get; set; }

        public void AddRandomRectangle()
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);

            RectangleShape rect = new RectangleShape(new Rectangle(x, y, 100, 200));

            rect.FillColor = Color.White;
            rect.BorderColor = Color.Black;
            rect.Opacity = 255;
            rect.BorderWidth = 1;

            RectangleList.Add(rect);
        }

        public void ReDraw(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Draw(e.Graphics);
        }

        public void Draw(Graphics grfx)
        {
            foreach (RectangleShape item in RectangleList)
            {
                item.DrawSelf(grfx);
            }

            foreach (var item in Selection)
            {
                item.RotateShape(grfx);
                if (item.GetType().Equals(typeof(TriangleShape)))
                    grfx.DrawRectangle(Pens.Black, item.Location.X - 3 - (item.BorderWidth / 2), item.Location.Y - 3 - (item.BorderWidth * 2), item.Width + 6 + (item.BorderWidth), item.Height + 6 + (float)(item.BorderWidth * 2.5));
                else
                    grfx.DrawRectangle(Pens.Black, item.Location.X - 3 - (item.BorderWidth / 2), item.Location.Y - 3 - (item.BorderWidth / 2), item.Width + 6 + (item.BorderWidth), item.Height + 6 + (item.BorderWidth));
                grfx.ResetTransform();
            }
        }

    }
}
