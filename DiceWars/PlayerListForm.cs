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
    public partial class PlayerListForm : Form
    {
        public PlayerListForm()
        {
            InitializeComponent();
        }

        private void PlayerListForm_Load(object sender, EventArgs e)
        {
            MdiParent = MyForms.GetForm<ParentForm>();
            LoadData();
        }

        public void LoadData()
        {
            dgv.DataMember = "";
            dgv.DataSource = null;
            dgv.DataSource = new PlayerManager().GetAll();
        }

        private void btn_re_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_sort_Click(object sender, EventArgs e)
        {
            dgv.DataMember = "";
            dgv.DataSource = null;
            dgv.DataSource = new PlayerManager().Sort();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (cb_filter.SelectedIndex < 0)
            {
                MessageBox.Show("Please select an attribute to filter by.");
            }
            else
            {
                ByAttribute selectedAttribute;
                if (cb_filter.SelectedIndex == 0)
                {
                    selectedAttribute = ByAttribute.Winners;
                }
                else
                {
                    selectedAttribute = ByAttribute.Losers;
                }
                dgv.DataMember = "";
                dgv.DataSource = null;
                dgv.DataSource = new PlayerManager().Filter(selectedAttribute);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a Player to edit.");
            }
            else
            {
                var p = (Player)dgv.SelectedRows[0].DataBoundItem;
                new PlayerEditForm().UpdatePlayer(p);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            new PlayerEditForm().CreateNewPlayer();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nothing selected to delete.");
            }
            else
            {
                var p = (Player)dgv.SelectedRows[0].DataBoundItem;
                new PlayerManager().Delete(p.pl_id_19257);
                LoadData();
            }
        }
    }
}
