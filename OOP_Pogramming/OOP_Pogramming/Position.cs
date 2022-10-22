using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Pogramming
{
    internal class Position
    {
        public int xPos;
        public int yPos;
        public int zPos;
        public int number;

        public string typeCord;

        public Position(int x, int y, int z)
        { 
            xPos = x;
            yPos = y;
            zPos = z;
        }

        public Position(string cord, int value)
        {
            typeCord = cord;
            number = value;
        }

        public void DisplayPosition()
        {
            Console.WriteLine($"Position of object is x = {xPos}, y = {yPos}, z = {zPos}");
        }
        public float CalculateDistance(Position pos)
        { 
            return (float) Math.Sqrt(Math.Pow(pos.xPos - xPos, 2) + Math.Pow(pos.yPos - yPos, 2) - Math.Pow(pos.zPos - zPos, 2));
        }
        public void DisplayDistance(float dis)
        {
            Console.WriteLine($"Distance between objects is equal to: {dis} units of distance.");
        }

        public void ChangePosition(Position pos)
        {
            switch (typeCord)
            {
                case "X":
                    pos.xPos += number;
                    break;

                case "Y":
                    pos.yPos += number;
                    break;

                case "Z":
                    pos.zPos += number;
                    break;
            }
        }
    }
}
