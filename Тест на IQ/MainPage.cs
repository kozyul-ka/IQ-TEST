using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;

namespace Тест_на_IQ
{
    public partial class MainPage : Form
    {
        
        public MainPage thisPage;
        public MainPage()
        {
            InitializeComponent();
        }
        public string NickName;

        private void Start()
        {
            if(Nickname_textBox.Text != "")
            {
                NickName = Nickname_textBox.Text;
                Form1 Test = new Form1();
                string path = @"..\..\Data\Results.txt";
                List<string> lines = System.IO.File.ReadAllLines(path).ToList();
                if (lines[lines.Count-1] != "")
                {
                    System.IO.File.WriteAllLines(path, lines.GetRange(0, lines.Count - 1).ToArray());
                }
                System.IO.File.AppendAllText(path, NickName);
                Test.Show();
                Hide();
            }
            else
            {
                MessageBox.Show(
                         "Вы не ввели свой ник",
                         "Сообщение",
                         MessageBoxButtons.OK
                         );
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Start();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }

        private void btn_CheckResult_Click(object sender, EventArgs e)
        {
            string path = @"..\..\Data\Results.txt";
            if (File.Exists(path))
            {
                List<string> lines = System.IO.File.ReadAllLines(path).ToList();
                if (lines[lines.Count - 1] != "")
                {
                    System.IO.File.WriteAllLines(path, lines.GetRange(0, lines.Count - 1).ToArray());
                }
                string[] message = File.ReadAllLines(path);
                string msg = "";
                for (int i = 0; i < message.Length; i++)
                {
                    msg += message[i];
                    msg += "\n";
                }
                MessageBox.Show(
                            msg,
                            "Результаты",
                            MessageBoxButtons.OK
                            );
            }
            else
            {
                MessageBox.Show(
                               "Файла с результатами еще нет",
                               "Результаты",
                               MessageBoxButtons.OK
                               );
            }
        }
        private void textBox1_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Start();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void btn_CheckResult_MouseEnter(object sender, EventArgs e)
        {
            this.btn_CheckResult.BackgroundImage = global::Тест_на_IQ.Properties.Resources.btnResHover;
        }

        private void btn_CheckResult_MouseLeave(object sender, EventArgs e)
        {
            this.btn_CheckResult.BackgroundImage = global::Тест_на_IQ.Properties.Resources.btnRes;
        }

        private void btn_Start_MouseEnter(object sender, EventArgs e)
        {
            this.btn_Start.BackgroundImage = global::Тест_на_IQ.Properties.Resources.btnBeginHover;
        }

        private void btn_Start_MouseLeave(object sender, EventArgs e)
        {
            this.btn_Start.BackgroundImage = global::Тест_на_IQ.Properties.Resources.btnBegin;
        }

        private void MainPage_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
