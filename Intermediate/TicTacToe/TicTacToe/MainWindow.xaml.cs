using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TicTacToe
{
    public partial class MainWindow : Window
    {
        static byte[,] table = new byte[3, 3];
        static bool turn = false;
        static byte turns = 0;
        static bool win = false;

        public MainWindow()
        {
            InitializeComponent();
            Status.Content = string.Format("Player {0}: Take your turn: ", (!turn) ? " 1 (X) " : " 2 (O) ");
        }
        private void CheckBoard()
        {
            for (int x = 0; x < 3; x++)
            {
                if (table[x, 0] > 0 && table[x, 0] == table[x, 1] && table[x, 1] == table[x, 2])
                {
                    win = true;
                    return;
                }
            }
            for (int y = 0; y < 3; y++)
            {
                if (table[0, y] > 0 && table[0, y] == table[1, y] && table[1, y] == table[2, y])
                {
                    win = true;
                    return;
                }
            }
            if (table[0, 0] > 0 && table[0, 0] == table[1, 1] && table[1, 1] == table[2, 2])
            {
                win = true;
                return;
            }
            if (table[2, 0] > 0 && table[2, 0] == table[1, 1] && table[1, 1] == table[0, 2])
            {
                win = true;
                return;
            }
        }
        private void Reset()
        {
            table = new byte[3, 3];
            win = false;
            turn = false;
            turns = 0;
            foreach(var c in GameGrid.Children)
            { 
                if (c is System.Windows.Controls.Button) //Check the type
                {
                    System.Windows.Controls.Button booten = c as System.Windows.Controls.Button;
                    booten.Content = "-";
                }
            }

        }
        private void WinSeq(bool draw)
        {
            if (draw){
                switch (System.Windows.Forms.MessageBox.Show("Play again?", "Draw!", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    case System.Windows.Forms.DialogResult.Yes:
                        Reset();
                        break;

                    case System.Windows.Forms.DialogResult.No:
                        Environment.Exit(0);
                        break;
                }
            }
            else
            {
                switch (System.Windows.Forms.MessageBox.Show("Play again?", string.Format("{0} won!", (!turn) ? "X" : "O"), MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    case System.Windows.Forms.DialogResult.Yes:
                        Reset();
                        break;

                    case System.Windows.Forms.DialogResult.No:
                        Environment.Exit(0);
                        break;
                }
            }
            
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Controls.Button button = sender as System.Windows.Controls.Button;
            if ((string)button.Content == "-") { 
                byte choice = Convert.ToByte(button.Name.Substring(1));
                button.Content = (!turn) ? "X" : "O";
                turns++;
                byte x = (byte)((choice - 1) / 3);
                byte y = (byte)((choice - 1) % 3);
                if (table[x, y] == 0)
                {
                    table[x, y] = (byte)((!turn) ? 2 : 1);
                    CheckBoard();
                    if (win)
                    {
                        WinSeq(false);
                    }
                    else if (turns == 9)
                    {
                        WinSeq(true);
                    }
                    else
                    {
                        turn = !turn;
                        Status.Content = string.Format("Player {0}: Take your turn: ", (!turn) ? " 1 (X) " : " 2 (O) ");
                    }
                }
            }
        }

    }
}
