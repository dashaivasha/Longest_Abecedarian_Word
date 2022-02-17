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
        public string GetS() => $"S = {Math.PI * Math.Pow(_radius,2)}";
        public string GetP() => $"P = {2 * Math.PI * _radius}";
    }
}
