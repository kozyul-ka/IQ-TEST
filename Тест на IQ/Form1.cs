﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Тест_на_IQ
{
    public partial class Form1 : Form
    {
        int n = 0;
        int[] answer;
        int[] rightAnswer = { 1, 2, 2, 8, 4, 5 ,3,4,4,10,90,2};

        public Form1()
        {
            InitializeComponent();
            answer = new int[12];
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            var picture1 = new Bitmap(Тест_на_IQ.Properties.Resources._1);
            pictureBox1.BackgroundImage = picture1;
        }
        public void show(int n)
        {
            int n1 = n + 1;
            label1.Text = "Вопрос №" + n1;
            switch (answer[n])
            {
                case 0:
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    radioButton5.Checked = false;
                    radioButton6.Checked = false;
                    break;
                case 1:
                    radioButton1.Checked = true;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    radioButton5.Checked = false;
                    radioButton6.Checked = false;
                    break;
                case 2:
                    radioButton1.Checked = false;
                    radioButton2.Checked = true;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    radioButton5.Checked = false;
                    radioButton6.Checked = false;
                    break;
                case 3:
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = true;
                    radioButton4.Checked = false;
                    radioButton5.Checked = false;
                    radioButton6.Checked = false;
                    break;
                case 4:
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = true;
                    radioButton5.Checked = false;
                    radioButton6.Checked = false;
                    break;
                case 5:
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    radioButton5.Checked = true;
                    radioButton6.Checked = false;

                    break;
                case 6:
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    radioButton5.Checked = false;
                    radioButton6.Checked = true;
                    break;

            }
            switch (n)
            {
                case 0:
                    pictureBox1.BackgroundImage = new Bitmap(Тест_на_IQ.Properties.Resources._1);
                    radioButton5.Visible = false;
                    radioButton6.Visible = false;
                    break;
                case 1:
                    pictureBox1.BackgroundImage = new Bitmap(Тест_на_IQ.Properties.Resources._2);
                    radioButton5.Visible = true;
                    radioButton6.Visible = true;
                    break;
                case 2:
                    pictureBox1.BackgroundImage = new Bitmap(Тест_на_IQ.Properties.Resources._3);
                    radioButton1.Visible = true;
                    radioButton2.Visible = true;
                    radioButton3.Visible = true;
                    radioButton4.Visible = true;
                    radioButton5.Visible = true;
                    radioButton6.Visible = true;
                    textBox1.Visible = false;
                    break;
                case 3:
                    pictureBox1.BackgroundImage = new Bitmap(Тест_на_IQ.Properties.Resources._4);
                    radioButton1.Visible = false;
                    radioButton2.Visible = false;
                    radioButton3.Visible = false;
                    radioButton4.Visible = false;
                    radioButton5.Visible = false;
                    radioButton6.Visible = false;
                    textBox1.Visible = true;
                    break;
                case 4:
                    pictureBox1.BackgroundImage = new Bitmap(Тест_на_IQ.Properties.Resources._5);
                    radioButton1.Visible = true;
                    radioButton2.Visible = true;
                    radioButton3.Visible = true;
                    radioButton4.Visible = true;
                    radioButton5.Visible = true;
                    radioButton6.Visible = true;
                    textBox1.Visible = false;
                    break;
                case 5:
                    pictureBox1.BackgroundImage = new Bitmap(Тест_на_IQ.Properties.Resources._6);
                    radioButton5.Visible = true;
                    radioButton6.Visible = false;
                    break;
                case 6:
                    pictureBox1.BackgroundImage = new Bitmap(Тест_на_IQ.Properties.Resources._7);
                    radioButton1.Visible = true;
                    radioButton2.Visible = true;
                    radioButton3.Visible = true;
                    radioButton4.Visible = true;
                    radioButton5.Visible = false;
                    radioButton6.Visible = false;
                    textBox1.Visible = false;
                    break;
                case 7:
                    pictureBox1.BackgroundImage = new Bitmap(Тест_на_IQ.Properties.Resources._8);
                    radioButton1.Visible = false;
                    radioButton2.Visible = false;
                    radioButton3.Visible = false;
                    radioButton4.Visible = false;
                    radioButton5.Visible = false;
                    radioButton6.Visible = false;
                    textBox1.Visible = true;
                    break;
                case 8:
                    pictureBox1.BackgroundImage = new Bitmap(Тест_на_IQ.Properties.Resources._9);
                    radioButton1.Visible = false;
                    radioButton2.Visible = false;
                    radioButton3.Visible = false;
                    radioButton4.Visible = false;
                    radioButton5.Visible = false;
                    radioButton6.Visible = false;
                    textBox1.Visible = true;
                    break;
                case 9:
                    pictureBox1.BackgroundImage = new Bitmap(Тест_на_IQ.Properties.Resources._10);
                    radioButton1.Visible = false;
                    radioButton2.Visible = false;
                    radioButton3.Visible = false;
                    radioButton4.Visible = false;
                    radioButton5.Visible = false;
                    radioButton6.Visible = false;
                    textBox1.Visible = true;
                    break;
                case 10:
                    pictureBox1.BackgroundImage = new Bitmap(Тест_на_IQ.Properties.Resources._11);
                    radioButton1.Visible = false;
                    radioButton2.Visible = false;
                    radioButton3.Visible = false;
                    radioButton4.Visible = false;
                    radioButton5.Visible = false;
                    radioButton6.Visible = false;
                    textBox1.Visible = true;
                    break;
                case 11:
                    pictureBox1.BackgroundImage = new Bitmap(Тест_на_IQ.Properties.Resources._12);
                    radioButton1.Visible = true;
                    radioButton2.Visible = true;
                    radioButton3.Visible = true;
                    radioButton4.Visible = true;
                    radioButton5.Visible = true;
                    radioButton6.Visible = true;
                    textBox1.Visible = false;
                    break;
            }

            if (n == answer.Length - 1)
            {
                button2.Text = "Закончить тест";
            }
            else
            {
                button2.Text = "Вперед";
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (n == 3 || (n>5 && n<11 ))
            {
                if (textBox1.Text != "")
                {
                    saveTextBoxMessage(int.Parse(textBox1.Text));
                    textBox1.Text="";
                }
            }
            n--;
            if (n < 0)
            {
                n = 0;
            }
            show(n);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (n == 3 || (n > 5 && n < 11))
            {
                if (textBox1.Text != "")
                {
                    saveTextBoxMessage(int.Parse(textBox1.Text));
                    textBox1.Text = "";
                }
            }
            n++;
            bool finish = false;
            if (n > answer.Length - 1)
            {
                n = answer.Length - 1;
                string questions = " ";
                bool haveUnchecked = false;
                for (int i = 0; i < answer.Length; i++)
                {
                    if (answer[i] == 0)
                    {
                        int a = i + 1;
                        haveUnchecked = true;
                        questions += "\n" + a.ToString();
                    }
                }
                if (haveUnchecked)
                {
                    MessageBox.Show(
                        "Ответьте на следующие вопросы:" + questions,
                        "Сообщение",
                        MessageBoxButtons.OK
                        );
                }
                else
                {
                    finish = true;
                }
            }
            if (finish)
            {
                finishTest();
            }
            else
            {
                show(n);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            answer[n] = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            answer[n] = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            answer[n] = 3;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            answer[n] = 4;
        }
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            answer[n] = 5;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            answer[n] = 6;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void saveTextBoxMessage(int message)
        {
            answer[n] = message;
        }

        private void finishTest()
        {
            double sumRightAns = 0;
            for (int i = 0; i < answer.Length; i++)
            {
                if(answer[i] == rightAnswer[i])
                {
                    sumRightAns++;
                }
            }
            double a = answer.Length;
            double result = sumRightAns / (a / 100);
            double iq = result * 1.6;
            label2.Visible = true;
            button1.Enabled = false;
            button2.Enabled = false;
            pictureBox1.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            radioButton6.Visible = false;
            label2.Text = "Ваш IQ: \n"

                + iq.ToString("00.")+"\n";
            string path = @"C:\Users\polue\Downloads\IQ_Test-master (2)\IQ_Test-master\Тест на IQ\Results.txt";
            System.IO.File.AppendAllText(path, " "+ DateTime.Now +" Ваш IQ:"+ iq );
            if (iq > 145)
            {
                label2.Text += "Еще чуть-чуть и вы Билл Гейтс";
            }
            else if(iq > 130 && iq <= 145)
            {
                label2.Text += "Ваш IQ как у Джессики Альбы";
            }
            else if (iq > 90 && iq <= 130)
            {
                label2.Text += "Вы среднестатистический россиянин";
            }
            else if(iq > 70 && iq  <= 90)
            {
                label2.Text += "Ваш интелект как у Сильвестрф Сталлоне ";
            }
            else if(iq > 40 && iq <= 70)
            {
                label2.Text += "Позанимайтесь ещё)";
            }
            else if (iq > 0 && iq <= 40)
            {
                label2.Text += "Ты - рыбка, и скоро это забудешь :)";
            }


        }
    }
}
