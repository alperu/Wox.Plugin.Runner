﻿using GalaSoft.MvvmLight;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wox.Plugin.Runner.Settings
{
    /// <summary>
    /// Interaction logic for RunnerSettings.xaml
    /// </summary>
    public partial class RunnerSettings : UserControl
    {
        public RunnerSettings()
        {
            InitializeComponent();
        }

        public RunnerSettings( ViewModelBase viewModel )
            : this()
        {
            DataContext = viewModel;
        }

        private void btnBrowse_Click( object sender, RoutedEventArgs e )
        {
            var dialog = new OpenFileDialog();
            dialog.DereferenceLinks = false;
            var result = dialog.ShowDialog();
            if ( result == true )
            {
                tbPath.Text = dialog.FileName;
            }
        }
    }
}
