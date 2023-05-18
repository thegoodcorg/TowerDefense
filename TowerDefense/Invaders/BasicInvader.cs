using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense.Invaders
{
    class BasicInvader : Invader
    {
        public override int Health { get; protected set; } = 2;

        public BasicInvader(Path path) : base(path)
        {

        }
    }
}
