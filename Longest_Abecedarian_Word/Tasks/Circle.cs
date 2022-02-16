using System;

namespace InternshipProject.Tasks
{
    public class Circle
    {
        private double _radius;
        public Circle(double radius)
        {
            _radius = radius;
        }
        public double GetS() => Math.PI * Math.Pow(_radius,2);
        public double GetP() => 2 * Math.PI * _radius;
    }
}
