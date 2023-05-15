using System;

namespace TowerDefense
{
    class Game
    {
        public static void Main()
        {
            Map map = new Map(8, 5);


            try
            {
                MapLocation mapLocation = new MapLocation(20, 20, map)
            }
            catch()
            {
                Console.WriteLine("That location is not on the map")
            }
        }
    }