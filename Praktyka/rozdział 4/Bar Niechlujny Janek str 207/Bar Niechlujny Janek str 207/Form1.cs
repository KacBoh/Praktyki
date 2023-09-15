using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bar_Niechlujny_Janek_str_207
{
    public partial class Form1 : Form
    {
        MenuMaker Menu;
        public Form1()
        {
            InitializeComponent();
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuMaker Menu = new MenuMaker { Randomizer = new Random() };
            label1.Text = Menu.GetMenuItem();
            label2.Text = Menu.GetMenuItem();
            label3.Text = Menu.GetMenuItem();
            label4.Text = Menu.GetMenuItem();
            label5.Text = Menu.GetMenuItem();
        }
    }
}
