using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class ShieldedInvader : Invader
    {
        private Random _random = new Random();
        public ShieldedInvader(Path path) : base(path)
        {

        }
        public override void DecreaseHealth(int factor)
        {
            if(_random.NextDouble() < 0.33)
            {
                base.DecreaseHealth(factor);
            }
            else
            {
            Console.WriteLine("Shot at a shielded invader but it took no damage!");

            }
        }

    }

}
