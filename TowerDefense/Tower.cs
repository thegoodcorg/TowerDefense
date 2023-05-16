namespace TowerDefense
{
    class Tower
    {
        private const int _range = 1;
        private const int _power = 1;

        private readonly MapLocation _location;
        public Tower(MapLocation location)
        {
            _location = location;
        }
        public void FireOnInvader(Invader[] invaders)
        {

            foreach (Invader invader in invaders)
            {
                if (invader.IsActive && _location.InRangeOf(invader.Location, _range))
                {
                    invader.DecreaseHealth(_power);
                    break;
                }
            }
        }
    }
}