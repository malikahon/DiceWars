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

namespace DiceWars
{
    public partial class PlayerEditForm : Form
    {
        public PlayerEditForm()
        {
            InitializeComponent();
        }

        public Player Player { get; set; }

        public FormMode Mode { get; set; }

        public void CreateNewPlayer()
        {
            Mode = FormMode.CreateNew;
            Player = new Player();
            InitializeControls();
            MdiParent = MyForms.GetForm<ParentForm>();
            Show();
        }

        public void UpdatePlayer(Player player)
        {
            Mode = FormMode.Update;
            Player = player;
            InitializeControls();
            ShowPlayerInControls();
            MdiParent = MyForms.GetForm<ParentForm>();
            dtp.Value = player.pl_last_game_date_19257;
            Show();
        }

        private void InitializeControls()
        {
        }

        private void ShowPlayerInControls()
        {
            tbx_name.Text = Player.pl_name_19257;
            cbx_pvp.Checked = Player.pl_is_pvp_enabled_19257;
        }

        private void GrabUserInput()
        {
            Player.pl_name_19257 = tbx_name.Text;
            Player.pl_is_pvp_enabled_19257 = cbx_pvp.Checked;
            Player.pl_last_game_date_19257 = dtp.Value;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbx_name.Text))
                {
                    MessageBox.Show("Sorry, player name cannot be empty.");
                }
                else
                {
                    GrabUserInput();
                    var manager = new PlayerManager();
                    if (Mode == FormMode.CreateNew)
                        manager.Create(Player);
                    else
                        manager.Update(Player);

                    MyForms.GetForm<PlayerListForm>().LoadData();
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PlayerEditForm_Load(object sender, EventArgs e)
        {

        }
    }
}
