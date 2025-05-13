namespace DiceWars
{
    partial class AddClashForm
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
            lbl_p1 = new Label();
            lbl_p2 = new Label();
            cb_1 = new ComboBox();
            cb_2 = new ComboBox();
            dtp = new DateTimePicker();
            lbl_dt = new Label();
            lbl_oc = new Label();
            cb_oc = new ComboBox();
            btn_add = new Button();
            SuspendLayout();
            // 
            // lbl_p1
            // 
            lbl_p1.AutoSize = true;
            lbl_p1.Location = new Point(28, 54);
            lbl_p1.Name = "lbl_p1";
            lbl_p1.Size = new Size(48, 15);
            lbl_p1.TabIndex = 0;
            lbl_p1.Text = "Player 1";
            // 
            // lbl_p2
            // 
            lbl_p2.AutoSize = true;
            lbl_p2.Location = new Point(28, 87);
            lbl_p2.Name = "lbl_p2";
            lbl_p2.Size = new Size(48, 15);
            lbl_p2.TabIndex = 1;
            lbl_p2.Text = "Player 2";
            // 
            // cb_1
            // 
            cb_1.FormattingEnabled = true;
            cb_1.Location = new Point(82, 51);
            cb_1.Name = "cb_1";
            cb_1.Size = new Size(232, 23);
            cb_1.TabIndex = 2;
            // 
            // cb_2
            // 
            cb_2.FormattingEnabled = true;
            cb_2.Location = new Point(82, 87);
            cb_2.Name = "cb_2";
            cb_2.Size = new Size(232, 23);
            cb_2.TabIndex = 3;
            // 
            // dtp
            // 
            dtp.Location = new Point(82, 125);
            dtp.Name = "dtp";
            dtp.Size = new Size(232, 23);
            dtp.TabIndex = 4;
            // 
            // lbl_dt
            // 
            lbl_dt.AutoSize = true;
            lbl_dt.Location = new Point(19, 131);
            lbl_dt.Name = "lbl_dt";
            lbl_dt.Size = new Size(57, 15);
            lbl_dt.TabIndex = 5;
            lbl_dt.Text = "DateTime";
            // 
            // lbl_oc
            // 
            lbl_oc.AutoSize = true;
            lbl_oc.Location = new Point(19, 169);
            lbl_oc.Name = "lbl_oc";
            lbl_oc.Size = new Size(57, 15);
            lbl_oc.TabIndex = 6;
            lbl_oc.Text = "Outcome";
            // 
            // cb_oc
            // 
            cb_oc.FormattingEnabled = true;
            cb_oc.Items.AddRange(new object[] { "Tie", "player1_won", "player2_won" });
            cb_oc.Location = new Point(82, 166);
            cb_oc.Name = "cb_oc";
            cb_oc.Size = new Size(232, 23);
            cb_oc.TabIndex = 7;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(19, 213);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(295, 23);
            btn_add.TabIndex = 8;
            btn_add.Text = "ADD GAME";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // AddClashForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_add);
            Controls.Add(cb_oc);
            Controls.Add(lbl_oc);
            Controls.Add(lbl_dt);
            Controls.Add(dtp);
            Controls.Add(cb_2);
            Controls.Add(cb_1);
            Controls.Add(lbl_p2);
            Controls.Add(lbl_p1);
            Name = "AddClashForm";
            Text = "AddClashForm";
            Load += AddClashForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_p1;
        private Label lbl_p2;
        private ComboBox cb_1;
        private ComboBox cb_2;
        private DateTimePicker dtp;
        private Label lbl_dt;
        private Label lbl_oc;
        private ComboBox cb_oc;
        private Button btn_add;
    }
}