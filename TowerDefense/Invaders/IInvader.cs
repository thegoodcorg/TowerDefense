using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense.Invaders
{
    interface IMappable
    {
        MapLocation Location { get; }
    }
    interface IMovable
    {
        void Move();
    }
    interface IInvader : IMappable, IMovable
    {

        int Health { get;  }
        bool HasScored { get; }
        bool IsNeutralized { get; }
        bool IsActive { get; }
        void DecreaseHealth(int factor);
    }
}
