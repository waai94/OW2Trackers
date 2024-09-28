using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsFormsApp1
{

   
   
    public partial class Form1 : Form
    {
        int gain;
        int elim;
        int damage;
        int dead;
        int heal;
        string day_time = DateTime.Now.ToString("yyyy/MM/dd");

        int today_winstreak = 0;
        int today_losestreak = 0;

        bool show_all_record = false;

        public struct record_info
        {
            public int gain_struct { get; set; }
            public int eliminated_struct { get; set; }
            public int damage_struct { get; set; }
            public int death_struct { get; set; }
            public string day_struct { get; set; }

            public int heal_struct { get; set; }
            public record_info(int gain_struct, int eliminated_struct, int damage_struct, int death_struct,string day,int heal_struct)
            {
                this.gain_struct = gain_struct;
                this.eliminated_struct= eliminated_struct;
                this.damage_struct = damage_struct;
                this.death_struct= death_struct;
                this.day_struct = day;
                this.heal_struct= heal_struct;
            }
        }

        List<record_info> record_list=new List<record_info>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadJsonData();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Console.Write("TextChanged");

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool failed_convert = false;
            gain = ConvertToInt(Gain.Text);
            failed_convert=IsNotFail(gain,failed_convert);
            elim=ConvertToInt(EliminationNum.Text);
            failed_convert = IsNotFail(elim,failed_convert);
            damage=ConvertToInt(DamageNum.Text);
            failed_convert = IsNotFail(damage, failed_convert);
            dead = ConvertToInt(DeathNum.Text);
            failed_convert = IsNotFail(dead, failed_convert);
            heal = ConvertToInt(heal_num.Text);
            failed_convert=IsNotFail(heal, failed_convert);

            
            if (failed_convert)
            {
                ConfirmLabel.Text = ("Error, Failed to convert ");
                MessageBox.Show("数値が無効です。");
            }
            else
            {
              //  ConfirmLabel.Text = ("Gain " + gain + " Elimination:" + elim + " Damage:" + damage + " Death:" + dead);
              record_list.Add(new record_info(gain,elim, damage, dead,day_time,heal));
                WriteJsons();
            }
           
          
        }
        //Jsonデータの読み込み
        private void LoadJsonData()
        {
            int today_point=0; //本日の盛れたポイント
            int today_kills = 0;
            int today_damage = 0;
            int today_death = 0;
            int today_games = 0;
            int today_wins = 0;
            int today_heals = 0;
         

            record_info ri = new record_info(0, 0, 0, 0,"",0);
            string json_from_file = File.ReadAllText("data.json");
            List<Record> records = JsonConvert.DeserializeObject<List<Record>>(json_from_file);
            int record_length=0;
            record_list.Clear();

            panel1.Controls.Clear();
            if (records==null)
            {
                Console.WriteLine("RECROD IS NULL");
                return;
            }
            int ws = 0;
            int ls = 0;
            foreach (Record r in records)
            {
               
                record_list.Add(new record_info(r.Result, r.Eliminate, r.Damage, r.Death,r.Date,r.Heal));
                AddResultToShow(record_length, record_list[record_length]);
                record_length++;
                Console.WriteLine(record_length.ToString());

                if (day_time == r.Date||show_all_record)
                {
                    today_point += r.Result;
                    today_kills += r.Eliminate;
                    today_damage += r.Damage;
                    today_death += r.Death;
                   today_heals += r.Heal;
                    today_games++;


                    if (r.Result > 0)
                    {
                        //win steak
                        today_wins++;
                        ws++;

                      

                        ls = 0;

                    }
                    else
                    {
                        //lose streak
                        ls++;
                       
                        ws = 0;
                    }

                    if (ls > today_losestreak)
                    {
                        today_losestreak = ls;


                       
                    }
                    if (ws > today_winstreak)
                    {
                        today_winstreak = ws;

                    }
                }
            }
            AddResultToShow(-1, new record_info(0,0,0,0,"",0));


            ShowTodayRecord(today_point,today_kills,today_damage,today_death,today_games,today_wins,ws,ls,today_winstreak,today_losestreak,today_heals);

            // label1.Text = (record_list[4].damage_struct.ToString());

        }

        //入力された文字を数列に変換
        private int ConvertToInt(string str)
        {
            int converted_num = 810;
            try
            {
                converted_num = Int32.Parse(str);
            }

            catch(FormatException)
            {

            }
            return converted_num;

        }
        private bool IsNotFail(int num,bool is_already_true)
        {
            
            return num==810||is_already_true;
        }

        //Jsonファイルへコンバート、書き込み
        void WriteJsons()
        {
            string json_string;

            List<Record> record=new List<Record>();
            foreach(record_info record_Info in record_list)
            {

                record.Add(new Record
                {
                    Result = record_Info.gain_struct,
                    Eliminate = record_Info.eliminated_struct,
                    Damage = record_Info.damage_struct,
                    Death = record_Info.death_struct,
                    Heal = record_Info.heal_struct,
                    Date = DateTime.Now.ToString("yyyy/MM/dd")

                });
            }
            json_string = JsonConvert.SerializeObject(record);
            Console.WriteLine(json_string);
            ConfirmLabel.Text = json_string;
            File.WriteAllText("data.json", json_string);
            LoadJsonData();

        }


        //読み込まれたデータをラベルに渡して表示
        private void AddResultToShow(int index_array,record_info info)
        {
            Label label = new Label();
            if (index_array > 0)
            {
             
                label.Text = record_list[index_array].gain_struct.ToString();
                label.AutoSize = true;
                label.Font = new Font(label1.Font.FontFamily, 15);
                label.Text = ("   "+info.gain_struct.ToString()+  "             " + info.eliminated_struct.ToString()+ "            " + info.death_struct.ToString()+ "                " + info.damage_struct.ToString()+"              "+info.heal_struct.ToString());
                if (info.gain_struct > 0)
                {
                    label.ForeColor = Color.Green;
                }
                else
                {
                    label.ForeColor= Color.Red;
                }
                label.Location = new Point(0, 20 + index_array * 30);
            }
            else
            {//七文字
                label.AutoSize = true;
                label.Font = new Font(label1.Font.FontFamily, 15);
                label.Location = new Point(0,  + index_array * 30);
                label.Text = ("Point   " + "Eliminates    " + "Deaths    " + " Damages   "+"  Heals");

            }
            

            panel1.Controls.Add(label);
        }

        //今日の試合結果を表示する　引数は左から　ポイント、キル数、ダメージ、デス数、今日のゲーム数 今日の勝利数 連勝数　連敗数 最高連勝数　最高連敗数
        private void ShowTodayRecord(int tp, int te, int td, int tdi, int today_games,int twins,int tws, int tls,int tmaxws, int tmaxls,int th)
        {

            float eliminate_avg = te / today_games;
            float damage_avg=td/today_games;
            float death_avg=tdi/today_games;
            float ratio = (float)te / (float)tdi;
            float winrates=(float)twins/today_games*100;
            float heal_avg = (float)th / today_games;
            
            if (tp > 0)
            {
                today_point_label.ForeColor = Color.Blue;
            }
            else
            {
                today_point_label.ForeColor = Color.Red;
            }

            today_day_label.Text = "今日は"+day_time;
            today_point_label.Text = (tp.ToString());

            todays_kill_label.Text = (eliminate_avg.ToString("F2"));
           today_damage_label.Text = (damage_avg.ToString("F2"));
            today_heal_label.Text = (heal_avg.ToString("F2"))
;            
            
            today_death_label.Text = (death_avg.ToString("F2"));
            today_killratio_rabel.Text = (ratio.ToString("F2"));
            winrate_label.Text = (winrates.ToString("F2")+"%");
            if (tws == tls)
            {
                now_game_streak_label.ForeColor = Color.Black;
                now_game_streak_label.Text = ("0");
            } else if (tws > tls)
            {
                now_game_streak_label.ForeColor = Color.Green;
                now_game_streak_label.Text = (tws.ToString());

            }
            else
            {
                now_game_streak_label.ForeColor= Color.Red;
                now_game_streak_label.Text = tls.ToString();
            }

            max_winstreak_label.ForeColor = Color.Green;
            max_winstreak_label.Text=tmaxws.ToString();

            max_losestreak_label.ForeColor = Color.Red;
            max_losestreak_label.Text = tmaxls.ToString();

         


          

        }

        private void ConfirmLabel_Click(object sender, EventArgs e)
        {

        }

        private void select_show_record_info_Click(object sender, EventArgs e)
        {
            show_all_record = !show_all_record;
            string str = "すべての記録を表示する";
            if(show_all_record)
            {
                str = "今日の記録のみを表示する";
            }
            select_show_record_info.Text = str;
            LoadJsonData();
        }
    }

   
}
