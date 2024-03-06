﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.kruchinina.var22
{
    public class Vector3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Vector3D ( double x, double y, double z )
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static Vector3D operator + ( Vector3D v1, Vector3D v2 )
        {
            return new Vector3D(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
        }

        public static Vector3D operator - ( Vector3D v1, Vector3D v2 )
        {
            return new Vector3D(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
        }

        public static double operator * ( Vector3D v1, Vector3D v2 )
        {
            return v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z;
        }

        public static Vector3D operator * ( Vector3D v, double scalar )
        {
            return new Vector3D(v.X * scalar, v.Y * scalar, v.Z * scalar);
        }

        public double GetLength ()
        {
            return Math.Sqrt(X * X + Y * Y + Z * Z);
        }

        public override string ToString ()
        {
            return "(" + X + ", " + Y + ", " + Z + ")";
        }

        public static bool operator == ( Vector3D v1, Vector3D v2 )
        {
            return v1.X == v2.X && v1.Y == v2.Y && v1.Z == v2.Z;
        }

        public static bool operator != ( Vector3D v1, Vector3D v2 )
        {
            return !( v1 == v2 );
        }

        public bool CompareTo ( Vector3D v )
        {
            return GetLength() == v.GetLength();
        }
    }
}
