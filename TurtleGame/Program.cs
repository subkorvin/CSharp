using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;
using Math = System.Math;

namespace TurtleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int windowWidth = GraphicsWindow.Width;
            int windowHeight = GraphicsWindow.Height;

            GraphicsWindow.KeyDown += GraphicsWindow_KeyDown;
            Turtle.PenUp();
            GraphicsWindow.BrushColor = "Red";
            var eat = Shapes.AddRectangle(10, 10);
            int eatX = 200;
            int eatY = 200;
            Shapes.Move(eat, eatX, eatY);
            Random rnd = new Random();
            
            while (true)
            {
                Turtle.Move(10);
                if (Turtle.X >= eatX - 10 && Turtle.X <= eatX + 20 && Turtle.Y >= eatY - 10 && Turtle.Y <= eatY + 20)
                {
                    eatX = rnd.Next(0, windowWidth);
                    eatY = rnd.Next(0, windowHeight);
                    Shapes.Move(eat, eatX, eatY);
                }
            }

        }

        private static void GraphicsWindow_KeyDown()
        {
            if (GraphicsWindow.LastKey == "Up")
            {
                Turtle.Angle = 0;
            } else if (GraphicsWindow.LastKey == "Right")
            {
                Turtle.Angle = 90;
            } else if (GraphicsWindow.LastKey == "Down")
            {
                Turtle.Angle = 180;
            } else if (GraphicsWindow.LastKey == "Left")
            {
                Turtle.Angle = 270;
            }
        }
    }
}
