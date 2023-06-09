﻿using MaterialDesignThemes.Wpf;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using WpfApp2.ViewModels;
using WpfApp2.Views;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    { 
        private readonly IRegionManager _regionManager;
        public MainWindow(IRegionManager regionManager)
        {
            _regionManager = regionManager;

            InitializeComponent(); 
        }
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            var newTab = new TabItem
            {
                Header = "New Tab",
                Content = new TabView()
            };
            TabControl1.Items.Add(newTab);
            TabControl1.SelectedItem = newTab;
        }
    }
}
