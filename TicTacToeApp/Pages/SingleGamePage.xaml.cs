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
    /// Логика взаимодействия для SingleGamePage.xaml
    /// </summary>
    public partial class SingleGamePage : Page
    {
        private SingleGame singleGame = new SingleGame();
        private List<Label> arrLabels;
        public SingleGamePage()
        {
            InitializeComponent();
        }

        private void Cell_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if ((string)((Label)sender).Content == "")
            {
                ((Label)sender).Content = singleGame.userSymbol.ToString();
                singleGame.putSymbol(arrLabels.IndexOf((Label)sender));
                if (singleGame.victoryCheck(singleGame.userSymbol))
                {
                    MessageBox.Show($"Победил {singleGame.userSymbol}");
                    restart();
                }
                else
                {
                    computerTurn();
                    if (singleGame.victoryCheck(singleGame.computerSymbol))
                    {
                        MessageBox.Show($"Победил {singleGame.computerSymbol}");
                        restart();
                    }
                }
                if (singleGame.drawCheck())
                {
                    MessageBox.Show("Ничья");
                    restart();
                }
            }
        }

        private void computerTurn()
        {
            int position = singleGame.computerTurn();
            if (position != -1)
            {
                arrLabels[position].Content = singleGame.computerSymbol.ToString();
            }
        }

        private void restart()
        {
            foreach (var cell in arrLabels)
            {
                cell.Content = "";
            }
            singleGame.restart();
            PlayerSymbolLabel.Content = $"Вы: {singleGame.userSymbol}";
            if(singleGame.userSymbol == 'O')
            {
                computerTurn();
            }
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            arrLabels = new List<Label> {Cell00, Cell01, Cell02, Cell10, Cell11, Cell12, Cell20, Cell21, Cell22};
            PlayerSymbolLabel.Content = $"Вы: {singleGame.userSymbol}";
        }

        private void ChangeSymbolButton_Click(object sender, RoutedEventArgs e)
        {
            singleGame.changeSymbol();
            restart();
        }
    }
}
