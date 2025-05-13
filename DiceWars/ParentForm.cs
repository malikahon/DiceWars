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
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            // we could also do Application.Exit(); but just for continuity sake let's do Close();
            // here, there's no diff, but in other windowsin the mainform you need close() so it doesn't kill ParentForm too
        }

        private void ParentForm_Load(object sender, EventArgs e)
        {
            //var manager = new PlayerManager();
            //MessageBox.Show(string.Join("\n", manager.GetAll().Select(t=>t.pl_name_19257)));
        }

        private void allPlayersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyForms.GetForm<PlayerListForm>().Show();
        }

        private void newPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PlayerEditForm().CreateNewPlayer();
        }

        private void allGamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyForms.GetForm<ClashListForm>().Show();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ClashForm().NewClash();
        }
    }
}
