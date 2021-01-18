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
using TicTacToeApp.Logic;

namespace TicTacToeApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для MultiGamePage.xaml
    /// </summary>
    public partial class MultiGamePage : Page
    {
        private MultiGame multiGame = new MultiGame();
        private List<Label> arrLabels;
        public MultiGamePage()
        {
            InitializeComponent();
        }

        private void Cell_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if ((string)((Label)sender).Content == "")
            {
                ((Label)sender).Content = multiGame.currentSymbol.ToString();
                multiGame.putSymbol(arrLabels.IndexOf((Label)sender), multiGame.currentSymbol);
                if (multiGame.victoryCheck(multiGame.currentSymbol))
                {
                    MessageBox.Show($"Победил {multiGame.currentSymbol}");
                    restart();
                }
                else if (multiGame.drawCheck())
                {
                    MessageBox.Show("Ничья");
                    restart();
                }
                else
                {
                    multiGame.changePlayer();
                    CurrentPlayerLabel.Content = $"Ход игрока: {multiGame.currentSymbol}";
                }
            }
        }

        private void restart()
        {
            foreach (var cell in arrLabels)
            {
                cell.Content = "";
            }
            multiGame.restart();
            CurrentPlayerLabel.Content = $"Ход игрока: {multiGame.currentSymbol}";
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            arrLabels = new List<Label> { Cell00, Cell01, Cell02, Cell10, Cell11, Cell12, Cell20, Cell21, Cell22 };
            CurrentPlayerLabel.Content = $"Ход игрока: {multiGame.currentSymbol}";
        }
    }
}
