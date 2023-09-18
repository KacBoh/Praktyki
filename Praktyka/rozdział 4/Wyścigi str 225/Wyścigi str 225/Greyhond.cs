using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyścigi_str_225
{
    internal class Greyhound
    {
        public int StartingPosition;
        public int RaceTrackLength;
        public PictureBox MyPictureBox;
        public int Location = 0;
        public Random MyRandom;

        public bool Run()
        {
            MyPictureBox.Left += MyRandom.Next(1, 4);
            Location = MyPictureBox.Left;
            if(MyPictureBox.Right >= RaceTrackLength)
            {
                return (true);
            }
            else return (false);

        }

        public void TakeStartingPosition()
        {
            Location = 0;
            MyPictureBox.Left = 0;

        }
    }
}
