﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMath
{
    public class Vector
    {
        private double x;
        private double y;

        private static Random random;

        public double X
        {
            get => x;
            set => x = value;
        }

        public double Y
        {
            get => y;
            set => y = value;
        }

        public double Length
        {
            get
            {
                return Math.Sqrt(x * x + y * y);
            }
        }

        public Vector()
        {
        }

        public void WriteLine()
        {
            Console.WriteLine("(x, y) = ({0}, {1})", x, y);
        }

        public static Vector Generate(double min, double max)
        {
            Vector v = new Vector();
            if (random == null)
                random = new Random();
            v.X = random.NextDouble(min, max);
            v.Y = random.NextDouble(min, max);
            return v;
        }

        public static Vector[] Generate(double min, double max, int count)
        {
            Vector[] vectors = new Vector[count];
            for (int index = 0; index < count; index++)
                vectors[index] = Vector.Generate(min, max);

            return vectors;
        }

        public static void WriteLine(Vector[] vectors)
        {
            foreach (var v in vectors)
                v.WriteLine();
        }
    }
}