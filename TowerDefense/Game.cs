using System;
using System.IO;
using TowerDefense.Invaders;

namespace TowerDefense
{
    class Game
    {
        public static void Main()
        {
            Map map = new Map(8, 5);


            try
            {
                Path path = new Path(
                    new[] {
                        new MapLocation(0,2, map),
                        new MapLocation(1,2, map),
                        new MapLocation(2,2, map),
                        new MapLocation(3,2, map),
                        new MapLocation(4,2, map),
                        new MapLocation(5,2, map),
                        new MapLocation(6,2, map),
                        new MapLocation(7,2, map)
                     } 
                    );

                //MapLocation location = new MapLocation(0,2, map);

                //if (path.IsOnPath(location))
                //{
                //    Console.WriteLine("Location is on the path.");
                //    return;
                //}
                Invader[] invaders =
                {
                    new ShieldedInvader(path),
                    new FastInvader(path),
                    new StrongInvader(path),
                    new BasicInvader(path)
                };
                Tower[] towers =
                {
                    new SniperTower(new MapLocation(1,3, map)),
                    new Tower(new MapLocation(3,3, map)),
                    new Tower(new MapLocation(5,3, map)),
                };


                Level level = new Level(invaders)
                {
                    Towers = towers
                };

                bool playerWon = level.Play();
                Console.WriteLine("Player " + (playerWon ? "won" : "lost"));
            }
            catch (OutOfBoundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (TowerDefenseException)
            {
                Console.WriteLine("Unhandled TowerDefense exception");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unhandled Exception" + ex);

            }
        }
    }
}