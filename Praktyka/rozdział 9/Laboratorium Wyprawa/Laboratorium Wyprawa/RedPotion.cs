﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium_Wyprawa
{
    internal class RedPotion : Weapon, IPotion
    {
        private bool used = false;
        public RedPotion(Game game, Point location) : base(game, location) { }

        public bool Used
        {
            get { return used; }
        }

        public override string Name
        {
            get { return "Czerwona mikstura"; }
        }

        public override void Attack(Direction direction, Random random)
        {
            game.IncreasePlayerHealth(10, random);
            used = true;
        }
    }
}
