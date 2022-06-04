using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPIApp.Server
{
    public class Service
    {
        public List<Shape> ShapeList { get; set; }
        public List<Shape> Selected { get; set; }

        public Service()
        {
            this.Selected = new List<Shape>();
            this.ShapeList = new List<Shape>();
        }


        public void AddRandomRectangle()
        {
            Random rnd = new Random();
            int x = rnd.Next(Utils.XMin, Utils.XMax);
            int y = rnd.Next(Utils.YMin, Utils.YMax);

            RectangleShape rect = new RectangleShape(new Rectangle(x, y, 100, 200));

            rect.FillColor = Color.White;
            rect.BorderColor = Color.Black;
            rect.Opacity = 255;
            rect.BorderWidth = 1;

            ShapeList.Add(rect);
        }


        public void Draw(Graphics grfx)
        {
            foreach (Shape item in ShapeList)
            {
                item.DrawSelf(grfx);
            }
        }
    }
}
