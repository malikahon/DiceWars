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
    public partial class ClashListForm : Form
    {
        public ClashListForm()
        {
            InitializeComponent();
        }

        // when it louds it should load data
        private void ClashListForm_Load(object sender, EventArgs e)
        {
            MdiParent = MyForms.GetForm<ParentForm>();
            LoadData();
        }

        // a function to load all the games onto the dgv
        public void LoadData()
        {
            dgv.DataSource = new ClashManager().GetAll();
        }

        // what happens when we click the add button
        private void btn_add_Click(object sender, EventArgs e)
        {
            new ClashForm().NewClash();
            LoadData();
        }
    }
}
