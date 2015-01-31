using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    abstract class Shape
    {
        protected Guid id;
        public Shape()
        {
            id = Guid.NewGuid();
        }
        public virtual double GetArea()
        {
            throw new NotImplementedException();
        }
        public double GetPerim()
        {
            throw new NotImplementedException();
        }
    }

    class MyRectangle:Shape
    {
        public double width;
        public double height;
        public override double GetArea()
        {
            return width * height;
        }
        public string Id
        {
            get
            {
                return id + "RQ";
            }
        }
    }

    class MyEllipse:Shape
    {
        public double radius;
        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }
        public string Id
        {
            get
            {
                return id + "E";
            }
        }
    }
    
    class Programs
    {
        static void Main(string[] args)
        {
            MyRectangle r = new MyRectangle();

            r.height = 10;
            r.width = 20;
            Console.WriteLine(r.GetArea());
            Console.WriteLine(r.Id);

            MyEllipse e = new MyEllipse();
            e.radius = 5;
            Console.WriteLine(e.GetArea());
            Console.WriteLine(e.Id);
        }
    }
}
