using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;
using Math = System.Math;

namespace TurtleTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            Turtle.Speed = 7;

            Turtle.X = 200;
            Turtle.Y = 200;

            WriteT(100, 60);

            Turtle.X = 260;
            Turtle.Y = 200;

            WriteO(60, 30);

            Turtle.X = 300;
            Turtle.Y = 200;

            WriteP(60, 30);

            Turtle.X = 360;
            Turtle.Y = 200;

            WriteT(60, 30);

            Turtle.X = 500;
            Turtle.Y = 200;
        }

        static void WriteT(int sizeX, int sizeY)
        {
            Turtle.Angle = 0;
            Turtle.Move(sizeX);
            Turtle.Angle = 270;
            Turtle.Move(sizeY / 2);
            Turtle.Angle = 90;
            Turtle.Move(sizeY);

        }

        static void WriteO(double sizeX, double sizeY)
        {
            Turtle.Angle = 300;
            double z = Math.Sqrt(Math.Pow((sizeX / 5), 2) + Math.Pow((sizeY / 2), 2)) + 5;
            Turtle.Move(z);
            Turtle.Turn(60);
            Turtle.Move((sizeX / 5) * 3);
            Turtle.Turn(60);
            Turtle.Move(z);
            Turtle.Turn(60);
            Turtle.Move(z);
            Turtle.Turn(60);
            Turtle.Move((sizeX / 5) * 3);
            Turtle.Turn(60);
            Turtle.Move(z);
        }

        static void WriteP(int sizeX, int sizeY)
        {
            Turtle.Angle = 0;
            Turtle.Move(sizeX);
            for (int i = 0; i < 3; i++)
            {
                Turtle.TurnRight();
                Turtle.Move(sizeY);
            }
            
        }
    }
}
