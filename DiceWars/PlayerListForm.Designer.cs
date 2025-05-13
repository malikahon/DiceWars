namespace DiceWars
{
    partial class PlayerListForm
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
            plid19257DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            plname19257DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            plispvpenabled19257DataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            pllastgamedate19257DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            plscore19257DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            playerBindingSource = new BindingSource(components);
            btn_add = new Button();
            btn_edit = new Button();
            btn_del = new Button();
            btn_re = new Button();
            lbl_sort = new Label();
            btn_sort = new Button();
            cb_filter = new ComboBox();
            btn_search = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv.AutoGenerateColumns = false;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { plid19257DataGridViewTextBoxColumn, plname19257DataGridViewTextBoxColumn, plispvpenabled19257DataGridViewCheckBoxColumn, pllastgamedate19257DataGridViewTextBoxColumn, plscore19257DataGridViewTextBoxColumn });
            dgv.DataSource = playerBindingSource;
            dgv.Location = new Point(12, 12);
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowTemplate.Height = 25;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.Size = new Size(452, 248);
            dgv.TabIndex = 0;
            // 
            // plid19257DataGridViewTextBoxColumn
            // 
            plid19257DataGridViewTextBoxColumn.DataPropertyName = "pl_id_19257";
            plid19257DataGridViewTextBoxColumn.HeaderText = "ID";
            plid19257DataGridViewTextBoxColumn.Name = "plid19257DataGridViewTextBoxColumn";
            plid19257DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // plname19257DataGridViewTextBoxColumn
            // 
            plname19257DataGridViewTextBoxColumn.DataPropertyName = "pl_name_19257";
            plname19257DataGridViewTextBoxColumn.HeaderText = "NAME";
            plname19257DataGridViewTextBoxColumn.Name = "plname19257DataGridViewTextBoxColumn";
            plname19257DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // plispvpenabled19257DataGridViewCheckBoxColumn
            // 
            plispvpenabled19257DataGridViewCheckBoxColumn.DataPropertyName = "pl_is_pvp_enabled_19257";
            plispvpenabled19257DataGridViewCheckBoxColumn.HeaderText = "PVP ENABLED";
            plispvpenabled19257DataGridViewCheckBoxColumn.Name = "plispvpenabled19257DataGridViewCheckBoxColumn";
            plispvpenabled19257DataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // pllastgamedate19257DataGridViewTextBoxColumn
            // 
            pllastgamedate19257DataGridViewTextBoxColumn.DataPropertyName = "pl_last_game_date_19257";
            pllastgamedate19257DataGridViewTextBoxColumn.HeaderText = "LAST GAME DATE";
            pllastgamedate19257DataGridViewTextBoxColumn.Name = "pllastgamedate19257DataGridViewTextBoxColumn";
            pllastgamedate19257DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // plscore19257DataGridViewTextBoxColumn
            // 
            plscore19257DataGridViewTextBoxColumn.DataPropertyName = "pl_score_19257";
            plscore19257DataGridViewTextBoxColumn.HeaderText = "SCORE";
            plscore19257DataGridViewTextBoxColumn.Name = "plscore19257DataGridViewTextBoxColumn";
            plscore19257DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // playerBindingSource
            // 
            playerBindingSource.DataSource = typeof(DAL.Player);
            // 
            // btn_add
            // 
            btn_add.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_add.Location = new Point(479, 12);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(107, 57);
            btn_add.TabIndex = 1;
            btn_add.Text = "ADD";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_edit
            // 
            btn_edit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_edit.Location = new Point(479, 75);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(107, 57);
            btn_edit.TabIndex = 2;
            btn_edit.Text = "EDIT";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_del
            // 
            btn_del.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_del.Location = new Point(479, 138);
            btn_del.Name = "btn_del";
            btn_del.Size = new Size(107, 57);
            btn_del.TabIndex = 3;
            btn_del.Text = "DELETE";
            btn_del.UseVisualStyleBackColor = true;
            btn_del.Click += btn_del_Click;
            // 
            // btn_re
            // 
            btn_re.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_re.Location = new Point(479, 201);
            btn_re.Name = "btn_re";
            btn_re.Size = new Size(107, 57);
            btn_re.TabIndex = 4;
            btn_re.Text = "REFRESH";
            btn_re.UseVisualStyleBackColor = true;
            btn_re.Click += btn_re_Click;
            // 
            // lbl_sort
            // 
            lbl_sort.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_sort.AutoSize = true;
            lbl_sort.Location = new Point(12, 273);
            lbl_sort.Name = "lbl_sort";
            lbl_sort.Size = new Size(58, 15);
            lbl_sort.TabIndex = 5;
            lbl_sort.Text = "By Name:";
            // 
            // btn_sort
            // 
            btn_sort.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_sort.Location = new Point(82, 269);
            btn_sort.Name = "btn_sort";
            btn_sort.Size = new Size(382, 23);
            btn_sort.TabIndex = 6;
            btn_sort.Text = "SORT";
            btn_sort.UseVisualStyleBackColor = true;
            btn_sort.Click += btn_sort_Click;
            // 
            // cb_filter
            // 
            cb_filter.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cb_filter.FormattingEnabled = true;
            cb_filter.Items.AddRange(new object[] { "Winners", "Losers" });
            cb_filter.Location = new Point(17, 305);
            cb_filter.Name = "cb_filter";
            cb_filter.Size = new Size(241, 23);
            cb_filter.TabIndex = 7;
            // 
            // btn_search
            // 
            btn_search.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_search.Location = new Point(270, 304);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(194, 23);
            btn_search.TabIndex = 8;
            btn_search.Text = "FILTER";
            btn_search.UseVisualStyleBackColor = true;
            btn_search.Click += btn_search_Click;
            // 
            // PlayerListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 452);
            Controls.Add(btn_search);
            Controls.Add(cb_filter);
            Controls.Add(btn_sort);
            Controls.Add(lbl_sort);
            Controls.Add(btn_re);
            Controls.Add(btn_del);
            Controls.Add(btn_edit);
            Controls.Add(btn_add);
            Controls.Add(dgv);
            Name = "PlayerListForm";
            Text = "All Players";
            Load += PlayerListForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv;
        private Button btn_add;
        private Button btn_edit;
        private Button btn_del;
        private Button btn_re;
        private Label lbl_sort;
        private Button btn_sort;
        private ComboBox cb_filter;
        private Button btn_search;
        private DataGridViewTextBoxColumn plid19257DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn plname19257DataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn plispvpenabled19257DataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn pllastgamedate19257DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn plscore19257DataGridViewTextBoxColumn;
        private BindingSource playerBindingSource;
    }
}