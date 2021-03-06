﻿using PresenterViewModel;
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
using System.Windows.Shapes;

namespace PresenterView
{
    /// <summary>
    /// Interaction logic for DetailView.xaml
    /// </summary>
    public partial class DetailView : Window, IWindow, IDetail
    {
        public DetailView()
        {
            InitializeComponent();
        }

        public void ShowWindow(MainViewModel mvm)
        {
            DetailView _dv = new DetailView();
            DetailViewModel _dvm = (DetailViewModel) _dv.DataContext;
            _dvm.SetSelectedProduct(mvm);
            _dv.Show();
        }
    }
}
