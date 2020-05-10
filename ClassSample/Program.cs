using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Students studentObject = new Students();
            Marks marks = new Marks();
            marks.Maths = 95;
            marks.Physics = 90;
            marks.Chemistry = 89;
            studentObject.Marks = marks;

            Console.WriteLine("Maths = {0}", studentObject.Marks.Maths);
            Console.Read();
        }
    }
}
