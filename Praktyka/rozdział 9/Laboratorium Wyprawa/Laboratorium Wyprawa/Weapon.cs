using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium_Wyprawa
{
    abstract class Weapon : Mover
    {
        public bool Pickedup { get; private set; }
        public Weapon(Game game, Point location) : base(game, location)
        {
            Pickedup = false;
        }

        public void PickUpWeapon()
        {
            Pickedup = true;
        }

        public abstract string Name { get; }
        public abstract void Attack(Direction direction, Random random);

        protected bool DamageEnemy(Direction direction, int radius, int damage, Random random)
        {
            Point target = game.PlayerLocation;
            for(int distance = 0 ; distance < radius; distance++)
            {
                foreach (Enemy enemy in game.Enemies)
                {
                    if (Nearby(enemy.Location, target, distance))
                    {
                        enemy.Hit(damage, random);
                        return true;

                    }
                }
                target = Move(direction, target, game.Boundaries);
            }
            return false;
        }
    }
}
