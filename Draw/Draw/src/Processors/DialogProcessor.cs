using Draw.src.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw.src.Processors
{
    public class DialogProcessor : DisplayProcessor
    {
        public DialogProcessor()
        {
            this.Selection = new List<Shape>();
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

            ShapeList.Add(rect);
        }


        public override void Draw(Graphics grfx)
        {
            base.Draw(grfx);

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
