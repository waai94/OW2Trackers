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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.heal_num = new System.Windows.Forms.TextBox();
            this.select_show_record_info = new System.Windows.Forms.Button();
            this.title_label = new System.Windows.Forms.Label();
            this.today_heal_label = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.max_losestreak_label = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.max_winstreak_label = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.now_game_streak_label = new System.Windows.Forms.Label();
            this.labels = new System.Windows.Forms.Label();
            this.winrate_label = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.today_killratio_rabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.today_death_label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.today_damage_label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.today_day_label = new System.Windows.Forms.Label();
            this.todays_kill_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.today_point_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ConfirmLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.win_game_label = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lose_game_label = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Gain
            // 
            this.Gain.Location = new System.Drawing.Point(12, 58);
            this.Gain.Name = "Gain";
            this.Gain.Size = new System.Drawing.Size(206, 19);
            this.Gain.TabIndex = 0;
            this.Gain.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "取得/損失　ポイント";
            // 
            // Elimination
            // 
            this.Elimination.AutoSize = true;
            this.Elimination.Location = new System.Drawing.Point(10, 92);
            this.Elimination.Name = "Elimination";
            this.Elimination.Size = new System.Drawing.Size(37, 12);
            this.Elimination.TabIndex = 3;
            this.Elimination.Text = "キル数";
            this.Elimination.Click += new System.EventHandler(this.label2_Click);
            // 
            // EliminationNum
            // 
            this.EliminationNum.Location = new System.Drawing.Point(12, 107);
            this.EliminationNum.Name = "EliminationNum";
            this.EliminationNum.Size = new System.Drawing.Size(206, 19);
            this.EliminationNum.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "ダメージ数";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // DamageNum
            // 
            this.DamageNum.Location = new System.Drawing.Point(12, 216);
            this.DamageNum.Name = "DamageNum";
            this.DamageNum.Size = new System.Drawing.Size(206, 19);
            this.DamageNum.TabIndex = 4;
            this.DamageNum.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "デス数";
            // 
            // DeathNum
            // 
            this.DeathNum.Location = new System.Drawing.Point(13, 163);
            this.DeathNum.Name = "DeathNum";
            this.DeathNum.Size = new System.Drawing.Size(206, 19);
            this.DeathNum.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "入力する";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Location = new System.Drawing.Point(29, 465);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 57);
            this.panel1.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 256);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 12);
            this.label10.TabIndex = 31;
            this.label10.Text = "ヒール数";
            // 
            // heal_num
            // 
            this.heal_num.Location = new System.Drawing.Point(12, 271);
            this.heal_num.Name = "heal_num";
            this.heal_num.Size = new System.Drawing.Size(206, 19);
            this.heal_num.TabIndex = 30;
            // 
            // select_show_record_info
            // 
            this.select_show_record_info.Location = new System.Drawing.Point(296, 418);
            this.select_show_record_info.Name = "select_show_record_info";
            this.select_show_record_info.Size = new System.Drawing.Size(144, 23);
            this.select_show_record_info.TabIndex = 34;
            this.select_show_record_info.Text = "すべての記録を表示する";
            this.select_show_record_info.UseVisualStyleBackColor = true;
            this.select_show_record_info.Click += new System.EventHandler(this.select_show_record_info_Click);
            // 
            // title_label
            // 
            this.title_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.title_label.Location = new System.Drawing.Point(221, 35);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(263, 20);
            this.title_label.TabIndex = 58;
            this.title_label.Text = "入力を終えたらここをクリック";
            this.title_label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // today_heal_label
            // 
            this.today_heal_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.today_heal_label.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.today_heal_label.Location = new System.Drawing.Point(347, 213);
            this.today_heal_label.Name = "today_heal_label";
            this.today_heal_label.Size = new System.Drawing.Size(113, 17);
            this.today_heal_label.TabIndex = 57;
            this.today_heal_label.Text = "-130";
            this.today_heal_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("MS UI Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label14.Location = new System.Drawing.Point(356, 196);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 17);
            this.label14.TabIndex = 56;
            this.label14.Text = "平均ヒール数";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // max_losestreak_label
            // 
            this.max_losestreak_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.max_losestreak_label.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.max_losestreak_label.Location = new System.Drawing.Point(349, 319);
            this.max_losestreak_label.Name = "max_losestreak_label";
            this.max_losestreak_label.Size = new System.Drawing.Size(113, 17);
            this.max_losestreak_label.TabIndex = 55;
            this.max_losestreak_label.Text = "-130";
            this.max_losestreak_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label11.Font = new System.Drawing.Font("MS UI Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.Location = new System.Drawing.Point(372, 302);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 17);
            this.label11.TabIndex = 54;
            this.label11.Text = "連敗数";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // max_winstreak_label
            // 
            this.max_winstreak_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.max_winstreak_label.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.max_winstreak_label.Location = new System.Drawing.Point(218, 319);
            this.max_winstreak_label.Name = "max_winstreak_label";
            this.max_winstreak_label.Size = new System.Drawing.Size(113, 17);
            this.max_winstreak_label.TabIndex = 53;
            this.max_winstreak_label.Text = "-130";
            this.max_winstreak_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label13.Font = new System.Drawing.Font("MS UI Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label13.Location = new System.Drawing.Point(245, 302);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 17);
            this.label13.TabIndex = 52;
            this.label13.Text = "連勝数";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // now_game_streak_label
            // 
            this.now_game_streak_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.now_game_streak_label.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.now_game_streak_label.Location = new System.Drawing.Point(285, 386);
            this.now_game_streak_label.Name = "now_game_streak_label";
            this.now_game_streak_label.Size = new System.Drawing.Size(113, 17);
            this.now_game_streak_label.TabIndex = 51;
            this.now_game_streak_label.Text = "-130";
            this.now_game_streak_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labels
            // 
            this.labels.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labels.Font = new System.Drawing.Font("MS UI Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labels.Location = new System.Drawing.Point(276, 357);
            this.labels.Name = "labels";
            this.labels.Size = new System.Drawing.Size(150, 17);
            this.labels.TabIndex = 50;
            this.labels.Text = "現在の連勝/連敗数";
            this.labels.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // winrate_label
            // 
            this.winrate_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.winrate_label.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.winrate_label.Location = new System.Drawing.Point(341, 72);
            this.winrate_label.Name = "winrate_label";
            this.winrate_label.Size = new System.Drawing.Size(113, 17);
            this.winrate_label.TabIndex = 49;
            this.winrate_label.Text = "-130";
            this.winrate_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(341, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 17);
            this.label9.TabIndex = 48;
            this.label9.Text = "勝率";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // today_killratio_rabel
            // 
            this.today_killratio_rabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.today_killratio_rabel.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.today_killratio_rabel.Location = new System.Drawing.Point(285, 165);
            this.today_killratio_rabel.Name = "today_killratio_rabel";
            this.today_killratio_rabel.Size = new System.Drawing.Size(113, 17);
            this.today_killratio_rabel.TabIndex = 47;
            this.today_killratio_rabel.Text = "-130";
            this.today_killratio_rabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(308, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 17);
            this.label8.TabIndex = 46;
            this.label8.Text = "キル比率";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // today_death_label
            // 
            this.today_death_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.today_death_label.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.today_death_label.Location = new System.Drawing.Point(347, 123);
            this.today_death_label.Name = "today_death_label";
            this.today_death_label.Size = new System.Drawing.Size(113, 17);
            this.today_death_label.TabIndex = 45;
            this.today_death_label.Text = "-130";
            this.today_death_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(356, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 44;
            this.label7.Text = "平均デス数";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // today_damage_label
            // 
            this.today_damage_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.today_damage_label.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.today_damage_label.Location = new System.Drawing.Point(220, 213);
            this.today_damage_label.Name = "today_damage_label";
            this.today_damage_label.Size = new System.Drawing.Size(113, 17);
            this.today_damage_label.TabIndex = 43;
            this.today_damage_label.Text = "-130";
            this.today_damage_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(222, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 17);
            this.label6.TabIndex = 42;
            this.label6.Text = "平均ダメージ数";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // today_day_label
            // 
            this.today_day_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.today_day_label.Location = new System.Drawing.Point(350, 18);
            this.today_day_label.Name = "today_day_label";
            this.today_day_label.Size = new System.Drawing.Size(131, 12);
            this.today_day_label.TabIndex = 41;
            this.today_day_label.Text = "入力を終えたらここをクリック";
            this.today_day_label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // todays_kill_label
            // 
            this.todays_kill_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.todays_kill_label.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.todays_kill_label.Location = new System.Drawing.Point(220, 123);
            this.todays_kill_label.Name = "todays_kill_label";
            this.todays_kill_label.Size = new System.Drawing.Size(113, 17);
            this.todays_kill_label.TabIndex = 40;
            this.todays_kill_label.Text = "-130";
            this.todays_kill_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(218, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 17);
            this.label5.TabIndex = 39;
            this.label5.Text = "平均キル数";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // today_point_label
            // 
            this.today_point_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.today_point_label.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.today_point_label.Location = new System.Drawing.Point(218, 72);
            this.today_point_label.Name = "today_point_label";
            this.today_point_label.Size = new System.Drawing.Size(113, 17);
            this.today_point_label.TabIndex = 38;
            this.today_point_label.Text = "-130";
            this.today_point_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(218, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "ランクポイント";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConfirmLabel
            // 
            this.ConfirmLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ConfirmLabel.Location = new System.Drawing.Point(41, 307);
            this.ConfirmLabel.Name = "ConfirmLabel";
            this.ConfirmLabel.Size = new System.Drawing.Size(131, 12);
            this.ConfirmLabel.TabIndex = 36;
            this.ConfirmLabel.Text = "入力を終えたらここをクリック";
            this.ConfirmLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(43, 418);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 23);
            this.button2.TabIndex = 59;
            this.button2.Text = "データのリセット";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // win_game_label
            // 
            this.win_game_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.win_game_label.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.win_game_label.ForeColor = System.Drawing.Color.Lime;
            this.win_game_label.Location = new System.Drawing.Point(218, 268);
            this.win_game_label.Name = "win_game_label";
            this.win_game_label.Size = new System.Drawing.Size(113, 17);
            this.win_game_label.TabIndex = 61;
            this.win_game_label.Text = "-130";
            this.win_game_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label15.Font = new System.Drawing.Font("MS UI Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label15.Location = new System.Drawing.Point(245, 251);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 17);
            this.label15.TabIndex = 60;
            this.label15.Text = "勝利数";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lose_game_label
            // 
            this.lose_game_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lose_game_label.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lose_game_label.ForeColor = System.Drawing.Color.Red;
            this.lose_game_label.Location = new System.Drawing.Point(347, 268);
            this.lose_game_label.Name = "lose_game_label";
            this.lose_game_label.Size = new System.Drawing.Size(113, 17);
            this.lose_game_label.TabIndex = 63;
            this.lose_game_label.Text = "-130";
            this.lose_game_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label16.Font = new System.Drawing.Font("MS UI Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label16.Location = new System.Drawing.Point(372, 251);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 17);
            this.label16.TabIndex = 62;
            this.label16.Text = "敗北数";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 543);
            this.Controls.Add(this.lose_game_label);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.win_game_label);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.title_label);
            this.Controls.Add(this.today_heal_label);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.max_losestreak_label);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.max_winstreak_label);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.now_game_streak_label);
            this.Controls.Add(this.labels);
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
            this.Controls.Add(this.ConfirmLabel);
            this.Controls.Add(this.select_show_record_info);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.heal_num);
            this.Controls.Add(this.panel1);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox heal_num;
        private System.Windows.Forms.Button select_show_record_info;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Label today_heal_label;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label max_losestreak_label;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label max_winstreak_label;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label now_game_streak_label;
        private System.Windows.Forms.Label labels;
        private System.Windows.Forms.Label winrate_label;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label today_killratio_rabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label today_death_label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label today_damage_label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label today_day_label;
        private System.Windows.Forms.Label todays_kill_label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label today_point_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ConfirmLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label win_game_label;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lose_game_label;
        private System.Windows.Forms.Label label16;
    }
}

