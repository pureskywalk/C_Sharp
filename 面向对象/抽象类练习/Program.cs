using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 抽象类练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //使用多态求矩形的面积和周长以及圆的面积和周长
            Shape shape = new Square(5,6);
            double area = shape.GetArea();
            double perimeter = shape.GetPerimeter();
            Console.WriteLine("这个圆的面积是{0},周长是{1}",area,perimeter);

            Console.ReadKey();
        }
    }

    public abstract class Shape
    {
        public abstract double GetArea();
        public abstract double GetPerimeter();
    }

    public class Circle : Shape
    {
        private double _r;

        public double R
        {
            get { return _r; }
            set { _r = value; }
        }

        public Circle(double r)
        {
            this.R = r;
        }

        public override double GetArea()
        {
            return Math.PI * this.R * this.R;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * this.R;
        }
    }

    public class Square : Shape
    {
        private double _chang;

        public double Chang
        {
            get { return _chang; }
            set { _chang = value; }
        }

        private double _kuang;

        public double Kuang
        {
            get { return _kuang; }
            set { _kuang = value; }
        }

        public Square(double chang, double kuang)
        {
            this.Chang = chang;
            this.Kuang = kuang;
        }


        public override double GetArea()
        {
            return this.Chang * this.Kuang;
        }

        public override double GetPerimeter()
        {
            return (this.Chang + this.Kuang) * 2;
        }
    }
}
