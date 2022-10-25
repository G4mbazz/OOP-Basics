using System;

namespace OOP_Basics
{
    //Sebastian SUT22
    public class Circle
    {
        public decimal _radius;
        public decimal _area;
        public decimal _pi = 3.141m;
        public decimal _circleLength;
        public decimal _volume;
        public Circle(decimal radius)
        {
            _radius = radius;
        }
        public decimal getArea()
        {
            _area = _radius * _radius * _pi;
            _area = Math.Round(_area, 2, MidpointRounding.ToEven);
            return _area;
        }
        public decimal getLength()
        {
            _circleLength = 2 * _pi * _radius;
            _circleLength = Math.Round(_circleLength, 2, MidpointRounding.ToEven);
            return _circleLength;
        }
        public decimal getVolume()
        {
            _volume = 4 * _pi * _radius * _radius * _radius;
            _volume /= 3;
            _volume = Math.Round(_volume, 2, MidpointRounding.ToEven);
            return _volume;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle fiveRad = new Circle(5);
            Console.WriteLine(fiveRad.getArea());
            Console.WriteLine(fiveRad.getLength());
            Console.WriteLine(fiveRad.getVolume());
            Circle sixRad = new Circle(6);
            Console.WriteLine("\n" + sixRad.getArea());
            Console.WriteLine(sixRad.getLength());
            Console.WriteLine(sixRad.getVolume());
        }
    }
}
