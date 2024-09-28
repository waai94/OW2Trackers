namespace WindowsFormsApp1
{
    partial class Form1
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
            this.Gain = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Elimination = new System.Windows.Forms.Label();
            this.EliminationNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DamageNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DeathNum = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ConfirmLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.today_point_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.todays_kill_label = new System.Windows.Forms.Label();
            this.today_day_label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.today_damage_label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.today_death_label = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.today_killratio_rabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.winrate_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Gain
            // 
            this.Gain.Location = new System.Drawing.Point(535, 49);
            this.Gain.Name = "Gain";
            this.Gain.Size = new System.Drawing.Size(206, 19);
            this.Gain.TabIndex = 0;
            this.Gain.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(533, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "取得/損失　ポイント";
            // 
            // Elimination
            // 
            this.Elimination.AutoSize = true;
            this.Elimination.Location = new System.Drawing.Point(533, 83);
            this.Elimination.Name = "Elimination";
            this.Elimination.Size = new System.Drawing.Size(37, 12);
            this.Elimination.TabIndex = 3;
            this.Elimination.Text = "キル数";
            this.Elimination.Click += new System.EventHandler(this.label2_Click);
            // 
            // EliminationNum
            // 
            this.EliminationNum.Location = new System.Drawing.Point(535, 98);
            this.EliminationNum.Name = "EliminationNum";
            this.EliminationNum.Size = new System.Drawing.Size(206, 19);
            this.EliminationNum.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(533, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "ダメージ数";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // DamageNum
            // 
            this.DamageNum.Location = new System.Drawing.Point(535, 154);
            this.DamageNum.Name = "DamageNum";
            this.DamageNum.Size = new System.Drawing.Size(206, 19);
            this.DamageNum.TabIndex = 4;
            this.DamageNum.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(533, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "デス数";
            // 
            // DeathNum
            // 
            this.DeathNum.Location = new System.Drawing.Point(535, 207);
            this.DeathNum.Name = "DeathNum";
            this.DeathNum.Size = new System.Drawing.Size(206, 19);
            this.DeathNum.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(574, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "入力する";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ConfirmLabel
            // 
            this.ConfirmLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ConfirmLabel.AutoSize = true;
            this.ConfirmLabel.Location = new System.Drawing.Point(588, 242);
            this.ConfirmLabel.Name = "ConfirmLabel";
            this.ConfirmLabel.Size = new System.Drawing.Size(131, 12);
            this.ConfirmLabel.TabIndex = 9;
            this.ConfirmLabel.Text = "入力を終えたらここをクリック";
            this.ConfirmLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Location = new System.Drawing.Point(29, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 488);
            this.panel1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(523, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "今日のポイント";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // today_point_label
            // 
            this.today_point_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.today_point_label.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.today_point_label.Location = new System.Drawing.Point(523, 325);
            this.today_point_label.Name = "today_point_label";
            this.today_point_label.Size = new System.Drawing.Size(113, 17);
            this.today_point_label.TabIndex = 12;
            this.today_point_label.Text = "-130";
            this.today_point_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(523, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "平均キル数";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // todays_kill_label
            // 
            this.todays_kill_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.todays_kill_label.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.todays_kill_label.Location = new System.Drawing.Point(525, 376);
            this.todays_kill_label.Name = "todays_kill_label";
            this.todays_kill_label.Size = new System.Drawing.Size(113, 17);
            this.todays_kill_label.TabIndex = 14;
            this.todays_kill_label.Text = "-130";
            this.todays_kill_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // today_day_label
            // 
            this.today_day_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.today_day_label.Location = new System.Drawing.Point(572, 296);
            this.today_day_label.Name = "today_day_label";
            this.today_day_label.Size = new System.Drawing.Size(131, 12);
            this.today_day_label.TabIndex = 15;
            this.today_day_label.Text = "入力を終えたらここをクリック";
            this.today_day_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(646, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "平均ダメージ数";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // today_damage_label
            // 
            this.today_damage_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.today_damage_label.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.today_damage_label.Location = new System.Drawing.Point(644, 376);
            this.today_damage_label.Name = "today_damage_label";
            this.today_damage_label.Size = new System.Drawing.Size(113, 17);
            this.today_damage_label.TabIndex = 17;
            this.today_damage_label.Text = "-130";
            this.today_damage_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(655, 403);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "平均デス数";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // today_death_label
            // 
            this.today_death_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.today_death_label.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.today_death_label.Location = new System.Drawing.Point(646, 420);
            this.today_death_label.Name = "today_death_label";
            this.today_death_label.Size = new System.Drawing.Size(113, 17);
            this.today_death_label.TabIndex = 19;
            this.today_death_label.Text = "-130";
            this.today_death_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(546, 403);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "キル比率";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // today_killratio_rabel
            // 
            this.today_killratio_rabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.today_killratio_rabel.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.today_killratio_rabel.Location = new System.Drawing.Point(523, 420);
            this.today_killratio_rabel.Name = "today_killratio_rabel";
            this.today_killratio_rabel.Size = new System.Drawing.Size(113, 17);
            this.today_killratio_rabel.TabIndex = 21;
            this.today_killratio_rabel.Text = "-130";
            this.today_killratio_rabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(646, 308);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "勝率";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // winrate_label
            // 
            this.winrate_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.winrate_label.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.winrate_label.Location = new System.Drawing.Point(646, 325);
            this.winrate_label.Name = "winrate_label";
            this.winrate_label.Size = new System.Drawing.Size(113, 17);
            this.winrate_label.TabIndex = 23;
            this.winrate_label.Text = "-130";
            this.winrate_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 543);
            this.Controls.Add(this.winrate_label);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.today_killratio_rabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.today_death_label);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.today_damage_label);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.today_day_label);
            this.Controls.Add(this.todays_kill_label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.today_point_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ConfirmLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DeathNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DamageNum);
            this.Controls.Add(this.Elimination);
            this.Controls.Add(this.EliminationNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Gain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Gain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Elimination;
        private System.Windows.Forms.TextBox EliminationNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DamageNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DeathNum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ConfirmLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label today_point_label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label todays_kill_label;
        private System.Windows.Forms.Label today_day_label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label today_damage_label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label today_death_label;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label today_killratio_rabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label winrate_label;
    }
}

