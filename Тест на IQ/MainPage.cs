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
                System.IO.File.AppendAllText(path, " " + NickName);
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


        private void btn_CheckResult_Click(object sender, EventArgs e)
        {
            string path = @"..\..\Data\Results.txt";
            if (File.Exists(path))
            {
                string[] message = File.ReadAllLines(path);
                string msg = "";
                for (int i = 0; i < message.Length; i++)
                {
                    msg += message[i];
                    msg += "\n";
                    msg += NickName;
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
            //if (!File.Exists(@"..\..\Data\Results.txt"))
            //{
            //    var f = File.Create(@"..\..\Data\Results.txt");
            //    f.Close();
            //    MessageBox.Show(
            //                "Файла с результатами не было \n" +
            //                "Файл с результатами был создан",
            //                "Результаты",
            //                MessageBoxButtons.OK
            //                );
            //}
            //else
            //{
            //    string[] message = File.ReadAllLines(@"..\..\Data\Results.txt");
            //    string msg = "";
            //    for (int i = 0; i < message.Length; i++)
            //    {
            //        msg += message[i];
            //        msg += "\n";
            //    }
            //    MessageBox.Show(
            //                msg,
            //                "Результаты",
            //                MessageBoxButtons.OK
            //                );
            //}
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

        }
    }
}
