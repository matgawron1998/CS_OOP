using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Pogramming
{
    internal class Circle : Shape
    {
        private float circleRadius;

        public Circle(float _circleRadius)
        {
            circleRadius = _circleRadius;
        }

        public override float GetArea()
        {
            return (float)(Math.PI*Math.Pow(circleRadius, 2));
        }

        public override void Draw()
        {
            Console.WriteLine("Write a circle.");
        }
    }
}
