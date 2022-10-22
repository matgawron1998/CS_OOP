using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Pogramming
{
    internal class Square : Shape
    {
        public float squareLength;

        public Square(float _squareLength)
        {
            squareLength = _squareLength;
        }

        public override float GetArea()
        {
            return squareLength * squareLength;
        }

        public override void Draw()
        {
            Console.WriteLine("Draw a square.");
        }
    }
}
