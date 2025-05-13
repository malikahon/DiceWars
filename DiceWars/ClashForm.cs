using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiceWars.DAL;
using static DiceWars.DAL.Clash;

namespace DiceWars
{
    public partial class ClashForm : Form
    {
        public ClashForm()
        {
            InitializeComponent();
        }

        public Clash clash { get; set; }


        public void btn_play_Click(object sender, EventArgs e)
        {
            // verification - player cannot play against themselves
            if (cb1.SelectedIndex == cb2.SelectedIndex)
            {
                MessageBox.Show("Player cannot play against literally themself.");
            }
            // if two diff players, can go ahead and play
            else
            {
                // get random numbers for the "o"s in the game
                Random random = new Random();

                lbl_p1_1o.Text = random.Next(1, 7).ToString();
                lbl_p1_2o.Text = random.Next(1, 7).ToString();
                lbl_p1_3o.Text = random.Next(1, 7).ToString();
                lbl_p1_4o.Text = random.Next(1, 7).ToString();
                lbl_p1_5o.Text = random.Next(1, 7).ToString();
                lbl_p2_1o.Text = random.Next(1, 7).ToString();
                lbl_p2_2o.Text = random.Next(1, 7).ToString();
                lbl_p2_3o.Text = random.Next(1, 7).ToString();
                lbl_p2_4o.Text = random.Next(1, 7).ToString();
                lbl_p2_5o.Text = random.Next(1, 7).ToString();

                // calculate result for player 1
                var p1_result =
                    Convert.ToInt32(lbl_p1_1o.Text)
                    + Convert.ToInt32(lbl_p1_2o.Text)
                    + Convert.ToInt32(lbl_p1_3o.Text)
                    + Convert.ToInt32(lbl_p1_4o.Text)
                    + Convert.ToInt32(lbl_p1_5o.Text);
                lbl_p1_r.Text = p1_result.ToString();

                //calculate result for player 2
                var p2_result =
                    Convert.ToInt32(lbl_p2_1o.Text)
                    + Convert.ToInt32(lbl_p2_2o.Text)
                    + Convert.ToInt32(lbl_p2_3o.Text)
                    + Convert.ToInt32(lbl_p2_4o.Text)
                    + Convert.ToInt32(lbl_p2_5o.Text);
                lbl_p2_r.Text = p2_result.ToString();

                // display result (game logic)
                outcome oc = 0;
                var p_man = new PlayerManager();
                if (p1_result == p2_result)
                {
                    oc = outcome.tie;
                    lbl_winner.Text = "Well played! The game was a tie.";
                }
                else if (p1_result > p2_result)
                {
                    oc = outcome.player1_won;
                    lbl_winner.Text = "Good playing there Player 1! Player 1 Wins.";
                }
                else if (p1_result < p2_result)
                {
                    oc = outcome.player2_won;
                    lbl_winner.Text = "Good playing there Player 2! Player 2 Wins.";
                }

                // getting the player Ids
                var player_1 = (Player)cb1.SelectedItem;
                var player_2 = (Player)cb2.SelectedItem;
                var up_p1 = p_man.GetById(player_1.pl_id_19257);
                var up_p2 = p_man.GetById(player_2.pl_id_19257);

                // determining the outcome and logging it
                if (oc == outcome.tie)
                {
                    up_p1.pl_last_game_date_19257 = DateTime.Now;
                    up_p2.pl_last_game_date_19257 = DateTime.Now;
                    p_man.Update(up_p1);
                    p_man.Update(up_p2);
                }
                else if (oc == outcome.player1_won)
                {
                    up_p1.pl_score_19257 = up_p1.pl_score_19257 + 1;
                    up_p2.pl_score_19257 = up_p2.pl_score_19257 - 1;
                    up_p1.pl_last_game_date_19257 = DateTime.Now;
                    up_p2.pl_last_game_date_19257 = DateTime.Now;
                    p_man.Update(up_p1);
                    p_man.Update(up_p2);
                }
                else
                {
                    up_p2.pl_score_19257 = up_p2.pl_score_19257 + 1;
                    up_p2.pl_last_game_date_19257 = DateTime.Now;
                    up_p1.pl_score_19257 = up_p1.pl_score_19257 - 1;
                    up_p1.pl_last_game_date_19257 = DateTime.Now;
                    p_man.Update(up_p2);
                    p_man.Update(up_p1);
                }


                // getting the game outputand sticking it inside the database
                try
                {
                    GrabGameInput(oc);
                    var c_man = new ClashManager();
                    c_man.Create(clash);

                    MyForms.GetForm<ClashListForm>();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        // this is to restart the game, basically
        public void NewClash()
        {
            clash = new Clash();
            MdiParent = MyForms.GetForm<ParentForm>();
            Show();
        }

        // this grabs the players, the time, and outcome to log into database
        private void GrabGameInput(outcome oc)
        {
            clash.cl_player1_19257 = (Player)cb1.SelectedItem;
            clash.cl_player2_19257 = (Player)cb2.SelectedItem;
            clash.cl_date_19257 = DateTime.Now;
            clash.cl_outcome_19257 = oc;
        }

        //when form loads we should have only those who have pvp enabled as options for players in the comboboxes
        private void ClashForm_Load(object sender, EventArgs e)
        {
            var manager = new PlayerManager();

            var pls_1 = manager.GetEnabled();
            cb1.DataSource = pls_1;
            cb1.DisplayMember = "pl_name_19257";
            cb1.ValueMember = "pl_id_19257";

            var pls_2 = manager.GetEnabled();
            cb2.DataSource = pls_2;
            cb2.DisplayMember = "pl_name_19257";
            cb2.ValueMember = "pl_id_19257";
        }
    }
}
