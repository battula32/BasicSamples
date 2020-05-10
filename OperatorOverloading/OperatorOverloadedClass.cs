using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace OperatorOverloading
{
    public class OperatorOverloadedClass
    {
        public Point Point
        {
            get;
            set;
        }

        public static OperatorOverloadedClass operator +(OperatorOverloadedClass point1, OperatorOverloadedClass point2)
        {
            Point result = new Point(point1.Point.X + point2.Point.X, point1.Point.Y + point2.Point.Y);
            OperatorOverloadedClass obj = new OperatorOverloadedClass();
            obj.Point = result;
            return obj;
        }
    }

    //public class Square
    //{
    //    private double Side;
    //    //public Constructor if int is passed convert to double and assign to Side
    //    public Square(int s)
    //    {
    //        Console.WriteLine(".ctor with int argument");
    //        Side = (double)s;
    //    }
    //    //OverLoaded constructor with double argument
    //    public Square(double s)
    //    {
    //        Console.WriteLine(".ctor with double argument");
    //        Side = s;
    //    }
    //    //override ToString() method of object class.
    //    public override string ToString()
    //    {
    //        Console.WriteLine("Override object class's string");
    //        return this.Side.ToString();
    //    }
    //    //Overloading + operator to add 2 square objects and return new square object
    //    public static Square operator +(Square x, Square y)
    //    {
    //        Console.WriteLine("Overloading + with Square,Square");
    //        return new Square(x.Side + y.Side);
    //    }
    //    //Overloading + operator to add square objects with double side and return new square object
    //    public static Square operator +(Square x, double y)
    //    {
    //        Console.WriteLine("Overloading + with Square,double");
    //        return new Square(x.Side + y);
    //    }
    //    //Overloading + operator to add square objects with int side and return new square object
    //    //This is not necessary since C# automatically calls +(Square,double)
    //    public static Square operator +(Square x, int y)
    //    {
    //        Console.WriteLine("Overloading + with Square,int");
    //        return x + (double)y;
    //    }
    //    public static implicit operator Square(double s)
    //    {
    //        Console.WriteLine("Overloading = for Square s5=1.5 assignment");
    //        return new Square(s);
    //    }
    //    public static implicit operator Square(int s)
    //    {
    //        Console.WriteLine("Overloading = for Square s5=10 assignment");
    //        return new Square((double)s);
    //    }
    //    //OverLoading == operator
    //    public static bool operator ==(Square x, Square y)
    //    {
    //        Console.WriteLine("Overloading == with Square,Square");
    //        return x.Side == y.Side;
    //    }
    //    //OverLoading != operator
    //    public static bool operator !=(Square x, Square y)
    //    {
    //        Console.WriteLine("Overloading != with Square,Square");
    //        return !(x == y); //This will call to operator == simple way to implement !=
    //    }
    //    //Always override GetHashCode(),Equals when overloading ==
    //    public override bool Equals(object o)
    //    {
    //        return this == (Square)o;
    //    }
    //    public override int GetHashCode()
    //    {
    //        return (int)Side;
    //    }
    //    //OverLoading > operator
    //    public static bool operator >(Square x, Square y)
    //    {
    //        Console.WriteLine("Overloading > with Square,Square");
    //        return x.Side > y.Side;
    //    }
    //    //OverLoading < operator
    //    public static bool operator <(Square x, Square y)
    //    {
    //        Console.WriteLine("Overloading < with Square,Square");
    //        return x.Side < y.Side;
    //    }
    //    //OverLoading <= operator
    //    public static bool operator <=(Square x, Square y)
    //    {
    //        Console.WriteLine("Overloading <= with Square,Square");
    //        return (x < y) || (x == y); //Calls to operator == and <
    //    }
    //    //OverLoading >= operator
    //    public static bool operator >=(Square x, Square y)
    //    {
    //        Console.WriteLine("Overloading >= with Square,Square");
    //        return (x > y) || (x == y); //Calls to operator == and >
    //    }
    //    //Readonly Property
    //    public double Area
    //    {
    //        get
    //        {
    //            return 2 * Side;
    //        }
    //    }
    //}
}
