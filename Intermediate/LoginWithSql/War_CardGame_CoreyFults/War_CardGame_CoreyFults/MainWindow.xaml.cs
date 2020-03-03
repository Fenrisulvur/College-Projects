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

namespace War_CardGame_CoreyFults
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        int[] deck = new int[52]; // all zero by default
        int lastCardIndex = 0;
        string[] cards = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
        string[] suits = { "clubs", "diamonds", "hearts", "spades" };
        Random rand = new Random();

        int totalComputer = 0; // records total points for computer
        int totalPlayer = 0; // ditto for player
        int show = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnDeal_Click(object sender, EventArgs e)
        {
            //txtResult.Clear();
            txtResult.Text = "";
            Array.Clear(deck, 0, 52);

            for (int i = 0; i < 52; i++)
            {
                while (true)
                {
                    int num = rand.Next(1, 53); // get number between 1 and 52 inclusive
                    if (Array.IndexOf(deck, num) == -1) // not already used
                    {
                        deck[i] = num;
                        break;
                    }
                }
            }

            btnDeal.IsEnabled = false;
            btnPlay.IsEnabled = true;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            string score;
            string result;

            if (show == 26)
            {
                if (totalComputer > totalPlayer)
                    score = "Computer wins!";
                else if (totalComputer < totalPlayer)
                    score = "Player wins!";
                else
                    score = "It's a draw!";

                result = "";
                result += String.Format("Final result\r\n\r\n");
                result += String.Format(" Computer Score is {0}\r\n", totalComputer);
                result += String.Format(" Player Score is {0}\r\n\r\n", totalPlayer);
                result += score;
                result += "\r\n\r\nPress Deal button to start another game";
                txtResult.Text = result;
                lastCardIndex = 0;
                totalComputer = 0;
                totalPlayer = 0;
                show = 0;
                btnDeal.IsEnabled = true;
                btnPlay.IsEnabled = false;
                btnDeal.Focus();
                return;
            }

            string computerSuit;
            int computer = SelectCard(out computerSuit) - 1;
            string playerSuit;
            int player = SelectCard(out playerSuit) - 1;

            if (computer > player)
            {
                totalComputer += 2;
                score = "Computer gets 2 points";
            }
            else if (computer < player)
            {
                totalPlayer += 2;
                score = "Player gets 2 points";
            }
            else
            {
                totalComputer += 1;
                totalPlayer += 1;
                score = "1 point each";
            }

            result = "";
            result += String.Format("Show # {0}\r\n\r\n", show + 1);
            result += String.Format(" Computer has {0} of {1}\r\n", cards[computer], computerSuit);
            result += String.Format(" Player has {0} of {1}\r\n\r\n", cards[player], playerSuit);
            result += score;
            show++;
            if (show == 26)
            {
                result += "\r\n\r\nGame over - press Play button to display final result!";
            }
            txtResult.Text = result;
        }

        int SelectCard(out string suit)
        {
            int num = deck[lastCardIndex];
            lastCardIndex++;
            suit = suits[(num - 1) % 4];
            return (num - 1) / 4 + 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnPlay.IsEnabled = false;
        }
      }
}
