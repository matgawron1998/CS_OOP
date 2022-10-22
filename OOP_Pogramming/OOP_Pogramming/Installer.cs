using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Pogramming
{
    internal class Installer
    {
        public static void Game()
        {
            Game Cyber = new Game();
            Game Diablo4 = new Game();

            Cyber.Name = "Cyberpunk 2077";
            Cyber.ProductionYear = 2020;
            Cyber.Price = 199;

            Diablo4.Name = "Diablo 4";
            Diablo4.ProductionYear = 2023;
            Diablo4.Price = 299;

            Cyber.DisplayPrice();
            Cyber.DisplayContents();

            Diablo4.DisplayPrice();
            Diablo4.DisplayContents();
        }
    }
}
