﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class SniperTower : Tower 
    {
        protected override int Range { get; } = 2;

        protected override double Accuracy { get; } = 1.0;
        public SniperTower(MapLocation mapLocation) : base(mapLocation)
        {

        }
    }
}
