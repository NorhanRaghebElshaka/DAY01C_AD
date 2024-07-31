using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoC_AD01
{
    internal class Point : IComparable<Point>
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int _x, int _y)
        {
            X = _x;
            Y = _y;
        }
        public override string ToString()
        {
            return $"X = {X} , Y = {Y}";
        }

        //public int CompareTo(object? obj)
        //{
        //    //Point passedPoint = (Point)obj; // throw Exception
        //    // [unsafe casting]


        //    #region  1. is conditional operator
        //    //if(obj is Point passedPoint)
        //    //{
        //    //    // 1. obj is an object from "Point"
        //    //    // 2. obj is a object from type inheriteed from "point"

        //    //    if (this.X == passedPoint.X)
        //    //        return this.Y.CompareTo(passedPoint.Y);
        //    //    else
        //    //        return this.X.CompareTo(passedPoint.X);

        //    //}
        //    //if (obj is null)
        //    //    return 1;

        //    //return 1; 
        //    #endregion

        //    // 2. as casting operator

        //    Point passedPoint = obj as Point;
        //    // casting will succed , if obj is an object from "point
        //    // or object from type inherited from "point"" 
        //    // casting will fail [obj is null , obj is hamadaa]
        //    // if casting fail passedPoint will be = null

        //    if(passedPoint is not null)
        //    {
        //        if (this.X == passedPoint.X)
        //            return this.Y.CompareTo(passedPoint.Y);
        //        else
        //            return this.X.CompareTo(passedPoint.X);
        //    }

        //    return 1;








        //}

        public int CompareTo(Point? passedPoint)
        {
            if (passedPoint is not null)
            {
                if (this.X == passedPoint.X)
                    return this.Y.CompareTo(passedPoint.Y);
                else
                    return this.X.CompareTo(passedPoint.X);
            }
            return -1;
        }
    }
}
