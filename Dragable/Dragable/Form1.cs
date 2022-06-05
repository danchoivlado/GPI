using Dragable.Common;
using Dragable.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dragable
{
    public partial class Form1 : Form
    {
        public List<Shape> ShapeList { get; set; }

        public List<Shape> Selection { get; set; }

        public Form1()
        {
            this.ShapeList = new List<Shape>();
            this.Selection = new List<Shape>();
            InitializeComponent();
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            var eventFraphics = e.Graphics;
            foreach (Shape item in ShapeList)
            {
                item.DrawSelf(eventFraphics);
            }

            foreach (var item in Selection)
            {
                eventFraphics.DrawRectangle(Pens.Black, item.Location.X - 3 - (item.BorderWidth / 2), item.Location.Y - 3 - (item.BorderWidth / 2), item.Width + 6 + (item.BorderWidth), item.Height + 6 + (item.BorderWidth));
                eventFraphics.ResetTransform();
            }
        }

        private void drawRectangleSpeedButton_Click(object sender, EventArgs e)
        {
            int x = Utils.RandomX();
            int y = Utils.RandomY();

            RectangleShape rect = new RectangleShape(new Rectangle(x, y, Utils.rectangleWidth, Utils.rectangleHeight));

            rect = Utils.ModifyRectangle(rect);

            ShapeList.Add(rect);

            panel.Invalidate();
        }
    }
}
