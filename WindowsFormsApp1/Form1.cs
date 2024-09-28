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

namespace WindowsFormsApp1
{

   
   
    public partial class Form1 : Form
    {
        int gain;
        int elim;
        int damage;
        int dead;
        string day_time = DateTime.Now.ToString("yyyy/MM/dd");

       

        public struct record_info
        {
            public int gain_struct { get; set; }
            public int eliminated_struct { get; set; }
            public int damage_struct { get; set; }
            public int death_struct { get; set; }
            public string day_struct { get; set; }
            public record_info(int gain_struct, int eliminated_struct, int damage_struct, int death_struct,string day)
            {
                this.gain_struct = gain_struct;
                this.eliminated_struct= eliminated_struct;
                this.damage_struct = damage_struct;
                this.death_struct= death_struct;
                this.day_struct = day;
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
            if (failed_convert)
            {
                ConfirmLabel.Text = ("Error, Failed to convert ");
                MessageBox.Show("数値が無効です。");
            }
            else
            {
              //  ConfirmLabel.Text = ("Gain " + gain + " Elimination:" + elim + " Damage:" + damage + " Death:" + dead);
              record_list.Add(new record_info(gain,elim, damage, dead,day_time));
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


            record_info ri = new record_info(0, 0, 0, 0,"");
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
            foreach (Record r in records)
            {
                record_list.Add(new record_info(r.Result, r.Eliminate, r.Damage, r.Death,r.Date));
                AddResultToShow(record_length, record_list[record_length]);
                record_length++;
                Console.WriteLine(record_length.ToString());

                if (day_time == r.Date)
                {
                    today_point += r.Result;
                    today_kills += r.Eliminate;
                    today_damage += r.Damage;
                    today_death += r.Death;
                    today_games++;
                }
            }
            AddResultToShow(-1, new record_info(0,0,0,0,""));
            ShowTodayRecord(today_point,today_kills,today_damage,today_death,today_games);

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
                label.Text = ("   "+info.gain_struct.ToString()+  "             " + info.eliminated_struct.ToString()+ "            " + info.damage_struct.ToString()+ "           " + info.death_struct.ToString());
              
                label.Location = new Point(0, 20 + index_array * 30);
            }
            else
            {//七文字
                label.AutoSize = true;
                label.Font = new Font(label1.Font.FontFamily, 15);
                label.Location = new Point(0,  + index_array * 30);
                label.Text = ("Point   " + " Eliminates " + " Damage " + " Death ");

            }
            

            panel1.Controls.Add(label);
        }

        //今日の試合結果を表示する　引数は左から　ポイント、キル数、ダメージ、デス数、今日のゲーム数
        private void ShowTodayRecord(int tp, int te, int td, int tdi, int today_games)
        {
            if (tp > 0)
            {
                today_point_label.ForeColor = Color.Blue;
            }
            else
            {
                today_point_label.ForeColor = Color.Red;
            }
            today_point_label.Text = (tp.ToString());

            if (te > 0)
            {


            }
        }
    }

   
}
