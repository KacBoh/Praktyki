using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Podstawowa_aplikacja
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string name = "Quentin";
            int x = 3;
            x = x * 17;
            double d = Math.PI /2;

            MyLabel1.Text = "nazwa to " + name
                + "\n jest równe " + x
                + "\n jest równe " + d;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            int x = 5;
            if (x == 10)
            {
                MyLabel1.Text = "Jest 10";
            }
            else
            {
                MyLabel1.Text = "Nie jest 10";
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            int some_value = 4;
            string name = "Adrian";
            if((some_value == 3) && (name == "Kacper"))
            {
                MyLabel1.Text = "value jest równe 3 a imię Kacper";
            }
            MyLabel1.Text = "ten text jest wyswietlany niezależnie";

        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            int count = 0;

            while(count < 10)
            {
                count = count + 1;
            }

            for (int i = 0; i < 5; i++)
            {
                count = count - 1;
            }

            MyLabel1.Text = "Odpowiedź: " + count;
            
        }
    }
}
