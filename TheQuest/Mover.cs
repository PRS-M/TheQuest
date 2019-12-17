using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuest
{
    abstract class Mover
    {
        private const int MoveInterval = 10;
        protected Point location;
        protected Game game;
        public Point Location { get { return location; } }
        
        public Mover(Game game, Point location)
        {
            this.game = game;
            this.location = location;
        }

        public bool Nearby(Point locationToCheck, int distance)
        {
            return Nearby(locationToCheck, this.location, distance);
        }

        public bool Nearby(Point locationToCheck, Point secondLocationToCheck, int distance)
        {
            if (Math.Abs(secondLocationToCheck.X - locationToCheck.X) < distance && Math.Abs(secondLocationToCheck.Y - locationToCheck.Y) < distance)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Point Move(Direction direction, Rectangle boundaries)
        {
            return Move(direction, this.location, boundaries);
        }

        public Point Move(Direction direction, Point targetLocation, Rectangle boundaries)
        {
            Point newLocation = targetLocation;
            switch (direction)
            {
                case Direction.Up:
                    if (newLocation.Y - MoveInterval >= boundaries.Top)
                    {
                        newLocation.Y -= MoveInterval;
                    }
                    break;
                case Direction.Down:
                    if (newLocation.Y + MoveInterval <= boundaries.Bottom)
                    {
                        newLocation.Y += MoveInterval;
                    }
                    break;
                case Direction.Left:
                    if (newLocation.X - MoveInterval >= boundaries.Left)
                    {
                        newLocation.X -= MoveInterval;
                    }
                    break;
                case Direction.Right:
                    if (newLocation.X + MoveInterval <= boundaries.Right)
                    {
                        newLocation.X += MoveInterval;
                    }
                    break;
                default: break;
            }

            return newLocation;
        }
    }
}
