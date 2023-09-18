using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kontrolki_str_219
{
    internal class LabelBouncer
    {
        public Label Mylabel;

        public bool GoingForward = true;

        public void Move()
        {
            if(Mylabel != null)
            {
                if (GoingForward)
                {
                    Mylabel.Left += 5;
                    if(Mylabel.Left >= Mylabel.Parent.Width - Mylabel.Width)
                    {
                        GoingForward = false;
                    }
                }
                else
                {
                    Mylabel.Left -= 5;
                    if (Mylabel.Left <= 0)
                    {
                        GoingForward = true;
                    }
                }
                

            }
        }
    }
}
