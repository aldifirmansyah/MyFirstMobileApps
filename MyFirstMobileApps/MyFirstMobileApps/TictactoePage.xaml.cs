using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstMobileApps
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TictactoePage : ContentPage
	{
        private Button[] buttons = new Button[9];
        private TicTacToeGameEngine game = new TicTacToeGameEngine();
        private Boolean isFinished = false;

        public TictactoePage()
        {
            InitializeComponent();

            buttons[0] = button1;
            buttons[1] = button2;
            buttons[2] = button3;
            buttons[3] = button4;
            buttons[4] = button5;
            buttons[5] = button6;
            buttons[6] = button7;
            buttons[7] = button8;
            buttons[8] = button9;
        }

        private void button_Clicked(object sender, EventArgs e)
        {
            if (isFinished) return;

            game.SetButton((Button)sender, ModeratorLabel);
            if (game.CheckWinner(buttons, GameOverLabel, ModeratorLabel))
            {
                GameOverStackLayout.IsVisible = true;
                ModeratorStackLayout.IsVisible = false;
                isFinished = true;
            }
        }

        private void playagain_Clicked(object sender, EventArgs e)
        {
            game.ResetGame(buttons);
            GameOverStackLayout.IsVisible = false;
            ModeratorStackLayout.IsVisible = true;
            isFinished = false;
        }
    }
}