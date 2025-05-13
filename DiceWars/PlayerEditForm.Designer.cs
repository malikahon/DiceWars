namespace DiceWars
{
    partial class PlayerEditForm
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
            lbl_player = new Label();
            tbx_name = new TextBox();
            cbx_pvp = new CheckBox();
            btn_save = new Button();
            btn_cancel = new Button();
            lbl_lgd = new Label();
            dtp = new DateTimePicker();
            SuspendLayout();
            // 
            // lbl_player
            // 
            lbl_player.AutoSize = true;
            lbl_player.Location = new Point(12, 29);
            lbl_player.Name = "lbl_player";
            lbl_player.Size = new Size(77, 15);
            lbl_player.TabIndex = 4;
            lbl_player.Text = "Player Name:";
            // 
            // tbx_name
            // 
            tbx_name.Location = new Point(95, 26);
            tbx_name.Name = "tbx_name";
            tbx_name.Size = new Size(248, 23);
            tbx_name.TabIndex = 0;
            // 
            // cbx_pvp
            // 
            cbx_pvp.AutoSize = true;
            cbx_pvp.CheckAlign = ContentAlignment.MiddleRight;
            cbx_pvp.Checked = true;
            cbx_pvp.CheckState = CheckState.Checked;
            cbx_pvp.Location = new Point(12, 70);
            cbx_pvp.Name = "cbx_pvp";
            cbx_pvp.Size = new Size(327, 19);
            cbx_pvp.TabIndex = 3;
            cbx_pvp.Text = "Player v. Player Enabled                                                           ";
            cbx_pvp.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(12, 133);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(166, 23);
            btn_save.TabIndex = 1;
            btn_save.Text = "SAVE";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(184, 133);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(157, 23);
            btn_cancel.TabIndex = 2;
            btn_cancel.Text = "CANCEL";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // lbl_lgd
            // 
            lbl_lgd.AutoSize = true;
            lbl_lgd.Location = new Point(12, 104);
            lbl_lgd.Name = "lbl_lgd";
            lbl_lgd.Size = new Size(89, 15);
            lbl_lgd.TabIndex = 5;
            lbl_lgd.Text = "Last Game Date";
            // 
            // dtp
            // 
            dtp.Location = new Point(143, 98);
            dtp.Name = "dtp";
            dtp.Size = new Size(200, 23);
            dtp.TabIndex = 6;
            dtp.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // PlayerEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 205);
            Controls.Add(dtp);
            Controls.Add(lbl_lgd);
            Controls.Add(btn_cancel);
            Controls.Add(btn_save);
            Controls.Add(cbx_pvp);
            Controls.Add(tbx_name);
            Controls.Add(lbl_player);
            Name = "PlayerEditForm";
            Text = "Edit Player";
            Load += PlayerEditForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_player;
        private TextBox tbx_name;
        private CheckBox cbx_pvp;
        private Button btn_save;
        private Button btn_cancel;
        private Label lbl_lgd;
        private DateTimePicker dtp;
    }
}