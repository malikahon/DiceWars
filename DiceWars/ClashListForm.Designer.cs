namespace DiceWars
{
    partial class ClashListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dgv = new DataGridView();
            clid19257DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clplayer119257DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clplayer219257DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cldate19257DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cloutcome19257DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clashBindingSource = new BindingSource(components);
            btn_add = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clashBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AutoGenerateColumns = false;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { clid19257DataGridViewTextBoxColumn, clplayer119257DataGridViewTextBoxColumn, clplayer219257DataGridViewTextBoxColumn, cldate19257DataGridViewTextBoxColumn, cloutcome19257DataGridViewTextBoxColumn });
            dgv.DataSource = clashBindingSource;
            dgv.Location = new Point(12, 12);
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowTemplate.Height = 25;
            dgv.Size = new Size(543, 336);
            dgv.TabIndex = 0;
            // 
            // clid19257DataGridViewTextBoxColumn
            // 
            clid19257DataGridViewTextBoxColumn.DataPropertyName = "cl_id_19257";
            clid19257DataGridViewTextBoxColumn.HeaderText = "ID";
            clid19257DataGridViewTextBoxColumn.Name = "clid19257DataGridViewTextBoxColumn";
            clid19257DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clplayer119257DataGridViewTextBoxColumn
            // 
            clplayer119257DataGridViewTextBoxColumn.DataPropertyName = "cl_player1_19257";
            clplayer119257DataGridViewTextBoxColumn.HeaderText = "PLAYER1";
            clplayer119257DataGridViewTextBoxColumn.Name = "clplayer119257DataGridViewTextBoxColumn";
            clplayer119257DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clplayer219257DataGridViewTextBoxColumn
            // 
            clplayer219257DataGridViewTextBoxColumn.DataPropertyName = "cl_player2_19257";
            clplayer219257DataGridViewTextBoxColumn.HeaderText = "PLAYER2";
            clplayer219257DataGridViewTextBoxColumn.Name = "clplayer219257DataGridViewTextBoxColumn";
            clplayer219257DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cldate19257DataGridViewTextBoxColumn
            // 
            cldate19257DataGridViewTextBoxColumn.DataPropertyName = "cl_date_19257";
            cldate19257DataGridViewTextBoxColumn.HeaderText = "CLASH DATE";
            cldate19257DataGridViewTextBoxColumn.Name = "cldate19257DataGridViewTextBoxColumn";
            cldate19257DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cloutcome19257DataGridViewTextBoxColumn
            // 
            cloutcome19257DataGridViewTextBoxColumn.DataPropertyName = "cl_outcome_19257";
            cloutcome19257DataGridViewTextBoxColumn.HeaderText = "OUTCOME";
            cloutcome19257DataGridViewTextBoxColumn.Name = "cloutcome19257DataGridViewTextBoxColumn";
            cloutcome19257DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clashBindingSource
            // 
            clashBindingSource.DataSource = typeof(DAL.Clash);
            // 
            // btn_add
            // 
            btn_add.Location = new Point(561, 12);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(227, 336);
            btn_add.TabIndex = 1;
            btn_add.Text = "ADD";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // ClashListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_add);
            Controls.Add(dgv);
            Name = "ClashListForm";
            Text = "ClashListForm";
            Load += ClashListForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)clashBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv;
        private DataGridViewTextBoxColumn clid19257DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn clplayer119257DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn clplayer219257DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cldate19257DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cloutcome19257DataGridViewTextBoxColumn;
        private BindingSource clashBindingSource;
        private Button btn_add;
    }
}