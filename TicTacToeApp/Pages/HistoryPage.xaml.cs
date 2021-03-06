﻿using System;
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
using TicTacToeApp.Entities;

namespace TicTacToeApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для HistoryPage.xaml
    /// </summary>
    public partial class HistoryPage : Page
    {
        TicTacToeDBEntities ticTacToeDBEntities = new TicTacToeDBEntities();

        public HistoryPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            HistoryDataGrid.ItemsSource = ticTacToeDBEntities.Records.ToList();
        }
    }
}
