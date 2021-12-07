using System;

namespace KataVA
{
    public class Vector
    {
        public double X { get; set; }
        public double Y { get; set; }

        public int Vect;

        public Vector(int X, int Y)
        {
            this.X = X;
            this.Y = Y;

        }

        public double Magnitude()
        {
            return Math.Sqrt(X * X + Y * Y);

        }

        public double DotProduct(Vector VA, Vector VB)
        {
            double DotPro = ((VA.X * VA.X) + (VB.Y * VB.Y));
            return DotPro;
        }

        public double AngleBetween(Vector VA, Vector VB)
        {
            double AngleBet = DotProduct(VA, VB) / (VA.Magnitude() * VB.Magnitude()) * 180 / 3.14;
            return AngleBet;
        }

    }
}
