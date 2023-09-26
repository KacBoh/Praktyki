using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium_Wyprawa
{
    class Player : Mover
    {
        private Weapon equippedWeapon;

        public int HitPoints { get; private set; }

        public List<Weapon> inventory = new List<Weapon>();
        public List<string> Weapons
        {
            get
            {
                List<string> names = new List<string>();
                foreach (Weapon weapon in inventory)
                {
                    names.Add(weapon.Name);
                }
                return names;
            }
        }

        public Player (Game game, Point location) : base (game, location)
        {
            HitPoints = 10;
        }

        public void Hit(int maxDamage, Random random)
        {
            HitPoints -= random.Next(1, maxDamage);
        }

            public void IncreaseHealth(int health, Random random)
        {
            HitPoints += random.Next(1, health);
        }

        public void Equip(string weaponName)
        {
            foreach(Weapon weapon in inventory)
            {
                if(weapon.Name == weaponName)
                {
                    equippedWeapon = weapon;
                }
            }
        }

        public void Move(Direction direction)
        {
            base.location = Move(direction, game.Boundaries);
            if (!game.WeaponInRoom.PickedUp)
            {
                if (Math.Abs(game.WeaponInRoom.Location.X - this.location.X) <= 10 && Math.Abs(game.WeaponInRoom.Location.Y - this.location.Y) <= 10)
                {
                    game.WeaponInRoom.PickUpWeapon();
                    inventory.Add(game.WeaponInRoom);
                    if (inventory.Count() <= 1)
                        Equip(game.WeaponInRoom.Name);
                }

            }
        }

        public void Attack(Direction direction, Random random)
        {
            if(equippedWeapon != null)
            {
                equippedWeapon.Attack(direction,random);
            }
            if (equippedWeapon is IPotion)
            {
                inventory.Remove(equippedWeapon);
                equippedWeapon=null;
            }
        }




    }
}
