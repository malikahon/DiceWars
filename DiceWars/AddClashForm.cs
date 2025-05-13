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
    public partial class AddClashForm : Form
    {
        public AddClashForm()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

        }

        private void AddClashForm_Load(object sender, EventArgs e)
        {
            var manager = new PlayerManager();
            var pls_1 = manager.GetEnabled();
            cb_1.DataSource = pls_1;
            cb_1.DisplayMember = "pl_name_19257";
            cb_1.ValueMember = "pl_id_19257";

            var pls_2 = manager.GetEnabled();
            cb_2.DataSource = pls_2;
            cb_2.DisplayMember = "pl_name_19257";
            cb_2.ValueMember = "pl_id_19257";
        }

        private void GrabUserInput(outcome oc)
        {
            //Clash.cl_player1_19257 = cb_1.ValueMember;
            //Clash.cl_player2_19257 = cb_2.ValueMember;
            //Clash.cl_date_19257 = dtp.Value;
            //Clash.cl_outcome_19257 = cb_oc.Value;
        }
    }
}
