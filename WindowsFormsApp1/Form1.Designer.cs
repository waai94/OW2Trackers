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
            this.ConfirmLabel.Location = new System.Drawing.Point(572, 242);
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
            this.label4.Location = new System.Drawing.Point(505, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "今日のポイント";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // today_point_label
            // 
            this.today_point_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.today_point_label.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.today_point_label.Location = new System.Drawing.Point(503, 347);
            this.today_point_label.Name = "today_point_label";
            this.today_point_label.Size = new System.Drawing.Size(113, 18);
            this.today_point_label.TabIndex = 12;
            this.today_point_label.Text = "-130";
            this.today_point_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(628, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "今日のキル数";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // todays_kill_label
            // 
            this.todays_kill_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.todays_kill_label.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.todays_kill_label.Location = new System.Drawing.Point(628, 347);
            this.todays_kill_label.Name = "todays_kill_label";
            this.todays_kill_label.Size = new System.Drawing.Size(113, 18);
            this.todays_kill_label.TabIndex = 14;
            this.todays_kill_label.Text = "-130";
            this.todays_kill_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 544);
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
    }
}

