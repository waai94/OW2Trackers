using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WindowsFormsApp1
{
    //Jsonの初期化
    public class Record
    {
        public int Result { get; set; }
        public int Death { get; set; }

        public int Eliminate { get; set; }
        public int Damage { get; set; }

        public int Heal { get; set; }

        public string Date {  get; set; }

        internal static class Program
        {
            /// <summary>
            /// The main entry point for the application.
            /// </summary>
            [STAThread]
            static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
    
            }
        }
    }
}

