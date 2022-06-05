using Dragable.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Dragable.Common
{
    public class Utils
    {
        public static int RandomX()
        {
            Random rnd = new Random();
            return rnd.Next(xMin, xMax);
        }

        public static int RandomY()
        {
            Random rnd = new Random();
            return rnd.Next(yMin, yMax);
        }

        public static int xMin = 100;
        public static int yMin = 100;
        public static int xMax = 1000;
        public static int yMax = 600;
        public static int rectangleWidth = 100;
        public static int rectangleHeight = 200;

        public static RectangleShape ModifyRectangle(RectangleShape rectangleShape)
        {
            rectangleShape.FillColor = Color.White;
            rectangleShape.BorderColor = Color.Black;
            rectangleShape.Opacity = 255;
            rectangleShape.BorderWidth = 1;

            return rectangleShape;
        }
    }
}
