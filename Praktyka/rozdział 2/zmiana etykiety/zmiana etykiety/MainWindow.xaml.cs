using System;
using System.Collections.Generic;
using System.Linq;
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

namespace zmiana_etykiety
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (box.IsChecked == true)
            {
                if(Label.Text == "Text z lewej")
                {
                    Label.Text = "Text z prawej";
                    Label.HorizontalAlignment = HorizontalAlignment.Right;
                }
                else
                {
                    Label.Text = "Text z lewej";
                    Label.HorizontalAlignment = HorizontalAlignment.Left;
                }
            }
            else
            if (box.IsChecked == false)
            {
                Label.Text = "Zmienianie tekstu jest wyłączone";
                Label.HorizontalAlignment = HorizontalAlignment.Center;
            }
        }

        private void Checkbox_Checked(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
