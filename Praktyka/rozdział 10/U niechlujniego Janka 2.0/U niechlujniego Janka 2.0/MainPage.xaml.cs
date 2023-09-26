﻿using Bar_Niechlujny_Janek_str_207;
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

namespace U_niechlujniego_Janka_2._0
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        MenuMaker menuMaker = new MenuMaker();
        public MainPage()
        {
            InitializeComponent();

            pageLayoutStackpanel.DataContext = menuMaker;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            menuMaker.UpdateMenu();
        }
    }
}
