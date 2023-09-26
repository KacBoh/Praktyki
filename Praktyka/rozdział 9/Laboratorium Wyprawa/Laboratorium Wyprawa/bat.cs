using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium_Wyprawa
{
    class Bat : Enemy
    {
        public Bat(Game game, Point location) : base(game, location, 6)
        {
            
        }

        public override void Move(Random random)
        {
            if(HitPoints > 1)
            {
                Direction locationToMove;
                if (random.Next(1,2) == 1)
                {
                    locationToMove = FindPlayerDirection(game.PlayerLocation);
                }
                else
                {
                    locationToMove = (Direction)random.Next(1,4);
                }
                location = Move(locationToMove, game.Boundaries);

                if (NearPlayer())
                {
                    game.HitPlayer(2, random);
                }

            }
        }

    }
    
}
