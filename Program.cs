﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystemV2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HealthSystemV2.0");
            Console.WriteLine("V2.0 = w/ OOP");
            Console.WriteLine("");

            Player player = new Player("Jacob Yeomans");

            player.ShowHUD();
            player.TakeDamage(35);
            player.ShowHUD();
            player.TakeDamage(60);
            player.ShowHUD();
            player.RegenerateShield(15);
            player.ShowHUD();
            player.TakeDamage(75);
            player.ShowHUD();
            player.Heal(5);
            player.ShowHUD();
            player.TakeDamage(100);
            player.ShowHUD();
            player.TakeDamage(200);
            player.ShowHUD();

            Console.ReadKey(true);
        }
    }
}
