using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;





namespace Lancares
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered",
            BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
            null, animationPanel, new object[] { true });
        }
        GameSession Game;
        private void proceedButton_Click(object sender, EventArgs e)
        {
            Game = new GameSession();
            Game.CreateGame((int)playersCount.Value, (int)roundsCount.Value);
            nameLabel.Text = "Wybiera gracz " + (Game.ActivePlayer.ID+1).ToString()+":";
            panel1.Visible = false;
            panel2.Visible = true;
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            animationPanel.Paint += new PaintEventHandler(animationPanel_Paint);

        }
        int numberOfRectangles = 0;
        bool allRectangles = false;
        private void animationPanel_Paint(object sender, PaintEventArgs e)
        {
            if (!allRectangles)
            {
                for (int i = 0; i <= numberOfRectangles; i++)
                {
                    e.Graphics.FillRectangle(Brushes.White, new Rectangle(i * 20, 0, 4, animationPanel.Height));
                }
                if (numberOfRectangles == 30)
                {
                    allRectangles = true;
                }
                else
                numberOfRectangles++;
            }
            else
            {
                for(int i = numberOfRectangles+1; i>=0; i--)
                {
                    e.Graphics.FillRectangle(Brushes.White, new Rectangle(580-(i * 20), 0, 4, animationPanel.Height));
                }
                if (numberOfRectangles == 0)
                {
                    allRectangles = false;
                }
                else
                numberOfRectangles--;
            }
        }

        
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
        }

        private void chooseNameButton_Click_1(object sender, EventArgs e)
        {
            Game.ActivePlayer.Name = nameTextBox.Text;
            playersList.Text += Game.ActivePlayer.Name + Environment.NewLine;
            

            if (Game.GetActivePlayerID() < Game.PlayersCount - 1)
            {
                Game.ActivePlayer = Game.Players[Game.GetActivePlayerID() + 1];
                nameLabel.Text = "Wybiera gracz " + (Game.GetActivePlayerID() + 1).ToString() + ":";
                nameTextBox.Clear();  
            }
            else
            {
                chooseNameButton.Visible = false;
                playButton.Visible = true;
                nameTextBox.Visible = false;
                nameLabel.Visible = false;
                Game.ActivePlayer = Game.Players[0];
            }


        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = true;
            whosNextLabel.Text = "Wjeżdża na DJ'kę:\n\r" + Game.ActivePlayer.Name;
        }

        private void playersCount_ValueChanged(object sender, EventArgs e)
        {
            if (playersCount.Value != 0 && roundsCount.Value != 0)
                proceedButton.Visible = true;
            else
                proceedButton.Visible = false;
        }

        private void roundsCount_ValueChanged(object sender, EventArgs e)
        {
            if (playersCount.Value != 0 && roundsCount.Value != 0)
                proceedButton.Visible = true;
            else
                proceedButton.Visible = false;
        }

        private void proceedButton_MouseEnter(object sender, EventArgs e)
        {
            
            proceedButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            proceedButton.BackColor = System.Drawing.SystemColors.Window;
        }

        private void proceedButton_MouseLeave(object sender, EventArgs e)
        {
            proceedButton.ForeColor = System.Drawing.SystemColors.Window;
            proceedButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        }

        private void startRatingButton_Click(object sender, EventArgs e)
        {
            Game.SwitchPhase(PhaseName.Rating);
            Game.SetRatingQueue();
            Panel3Update(Game);

        }

        private void rateButton_Click(object sender, EventArgs e)
        {
            if (Game.Rate((int)markChooseMenu.Value))
            {
                Panel3Update(Game);
            }
            else if (Game.RatingQueue.Count == 0 && Game.CurrentRound == Game.RoundsCount)
            {
                Game.SwitchPhase(PhaseName.Summary);
                Panel3Update(Game);
            }
            else 
            {
                RatingPanel.Visible = false;
                whosNextPanel.Visible = true;
                if(Game.GetActivePlayerID()<Game.PlayersCount-1)
                whosNextLabel.Text = "Wjeżdża na DJ'kę:\n\r" + Game.Players[Game.GetActivePlayerID()+1].Name;
            }
            
        }

    
       
        private void Panel3Update(GameSession game)
        {
            if(game.Phase==PhaseName.Rating)
            {
                TrackPlayingPanel.Visible = false;
                RatingPanel.Visible = true;
                animationPanel.Visible = false;
                timer1.Enabled = false;
                whosNextPanel.Visible = false;
                Player player = Game.RatingQueue.Dequeue();
                ratingPlayer.Text = player.Name;
                
            }
            else if (game.Phase == PhaseName.TrackPlaying)
            {
                TrackPlayingPanel.Visible = true;
                RatingPanel.Visible = false;
                whosNextPanel.Visible = false;
                activePlayerLabel.Text = game.ActivePlayer.Name;
                animationPanel.Visible = true;
                timer1.Enabled = true;
                numberOfRectangles = 0;
            }
            else
            {
                RatingPanel.Visible = false;
                TrackPlayingPanel.Visible = false;
                whosNextPanel.Visible = false;
                scoreNamesLabel.Text = Game.ScoreNames();
                scoreValuesLabel.Text = Game.ScoreValues();
                scorePanel.Visible = true;
                timer1.Enabled = false;
                
            }
            


        }

        private void startTrackPlaying_Click(object sender, EventArgs e)
        {
            Game.SwitchPhase(PhaseName.TrackPlaying);
            Game.ActivePlayer = Game.Players[Game.CurrentRound % Game.PlayersCount];
            Panel3Update(Game);
            Game.CurrentRound++;
        }

        private void scorePanel_Paint(object sender, PaintEventArgs e)
        {
            if (scorePanel.BorderStyle == BorderStyle.FixedSingle)
            {
                int thickness = 3;//it's up to you
                int halfThickness = thickness / 2;
                using (Pen p = new Pen(Color.White, thickness))
                {
                    e.Graphics.DrawRectangle(p, new Rectangle(halfThickness,
                                                              halfThickness,
                                                              scorePanel.ClientSize.Width - thickness,
                                                              scorePanel.ClientSize.Height - thickness));
                }
            }
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }
    }
}
