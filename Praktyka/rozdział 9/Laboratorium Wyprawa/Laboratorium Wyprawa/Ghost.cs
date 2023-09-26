﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium_Wyprawa
{
    internal class Ghost : Enemy
    {
        public Ghost(Game game, Point location) : base(game, location, 8) { }

        public override void Move(Random random)
        {
            if (HitPoints >= 1)
            {
                Direction playerDirection = FindPlayerDirection(game.PlayerLocation);
                if (random.Next(1, 3) == 1)
                    location = Move(playerDirection, game.Boundaries);

                if (NearPlayer())
                    game.HitPlayer(3, random);
            }
        }


    }
}
