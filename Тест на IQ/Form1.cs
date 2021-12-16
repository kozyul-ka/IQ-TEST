using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Тест_на_IQ
{
    public partial class Form1 : Form
    {
        int n = 0;
        int[] answer;
        int[] rightAnswer;
        Task[] TaskArray =
        {   
            //Номер изображения;Текст задания; Текст Радиокнопок; Включать ли текстбокс; Номер правильного ответа
            
            //0 - нет изображения; "" - нет описания задания; 
            //если у нас есть текстбокс, то строка со значениями радиокнопок должна быть пустой;

            new Task(1, "Выберите недостающую фигуру", "123456", false, 1),
            new Task(2, "Выберите недостающую фигуру", "123456", false, 2),
            new Task(3, "Выберите недостающую фигуру", "123456", false, 2),
            new Task(4, "Какое число пропущенно?", "", true, 8),
            new Task(5, "Выберите недостающую фигуру", "123456", false, 4),
            new Task(6, "Выберите недостающую фигуру", "12345", false, 5 ), 

            //дальше ответы верные, 12 вопросов от --Ю
            new Task(7, "Найдите ячейку с другим оттенком красного.", "123456", false, 3), 
            new Task(8, "Продолжите ряд…", "ФКАВЛ", false, 4), 
            new Task(9, "Найдите логику и выберите верный вариант", "0123", false, 2), 
            new Task(10, "Какая из этих черных фигур полностью соответствует красной фигуре?", "ABCDEFG", false, 2), 
            new Task(0, "Вставьте пропущенную цифру. \n \n2 5 8 11 _", "", true, 14),
            new Task(0, "Вставьте недостающую цифру. \n \n2   5   7 \n \n4   7   5 \n\n3   6   _", "", true, 6),
            new Task(11, "Какая из шести пронумерованных фигур должна занять свободное место?", "123456", false, 5),
            new Task(12, "Какая из шести пронумерованных фигур должна занять свободное место?", "123456", false, 3),
            new Task(13, "Вставьте недостающую цифру.", "", true, 32),
            new Task(14, "Выберите лишнюю фигуру.", "12345", false, 5),
            new Task(0, "Вставьте недостающую букву: \n\n Д Ж К Н С __", "ВДЩФКТ", false, 4),
            new Task(15, "Какая из шести пронумерованных фигур должна занять свободное место?", "123456", false, 3),
            new Task(0, "Количество букв слове УтКа?", "", true, 4),
            
            //

            new Task(16, "", "1234", false, 4 ),
            new Task(17, "Вставьте недостающую букву: ", "АУЯНАЫ", false, 2),// ДОДЕЛАТЬ ответ
            new Task(18, "Вставьте недостающую цифру ", "", true, 4),
            new Task(19, "Вставьте недостающую цифру ", "", true, 10),
            new Task(20, "Вставьте недостающую цифру ", "", true, 90),
            new Task(21, "Выберите недостающую фигуру", "123456", false, 6 ),
           // new Task(0, "Сколько красных автомобилей в день производит автозавод?Автозавод производит 1000 кузовов в день для белых, черных, зеленых и красныхавтомобилей в пропорции  3 : 9 : 8 : 5  соответственно.", "200 190 210 250 320", false, 1)
        };

        RadioButton[] radioButtons;
        TextBox[] TB;
        List<Bitmap> images = new List<Bitmap>();

        public Form1()
        {
            InitializeComponent();

            answer = new int[TaskArray.Length];
            radioButtons = this.Controls.OfType<RadioButton>().ToArray();
            TB = this.Controls.OfType<TextBox>().ToArray();

            RadioButton[] _rb = new RadioButton[radioButtons.Length];
            for(int i = 0; i < radioButtons.Length; i++)
            {
                _rb[i] = radioButtons[radioButtons.Length - (i + 1)];
            }
            radioButtons = _rb;

            //собираем имеющиеся картинки
            List<int> vv = new List<int>();
            List<int> vv1 = new List<int>();

            Type t = typeof(Тест_на_IQ.Properties.Resources);
            foreach (PropertyInfo prop in t.GetProperties(BindingFlags.Static | BindingFlags.NonPublic))
            {
                if (prop.PropertyType == typeof(Bitmap))
                {
                    Regex regex = new Regex(@"_(\d*)");
                    MatchCollection matches = regex.Matches(prop.Name);
                    if (matches.Count >= 1) {
                        string a = prop.Name;
                        vv.Add(int.Parse(a.Substring(1, a.Length - 1)));
                        vv1.Add(int.Parse(a.Substring(1, a.Length - 1)));
                        images.Add((Bitmap)prop.GetValue(t));
                    }
                }
            }
            
            vv.Sort();
            SortImages(vv, vv1);

            //собираем правильные ответы
            rightAnswer = new int[TaskArray.Length];
            for (int i = 0; i < TaskArray.Length; i++)
            {
                rightAnswer[i] = TaskArray[i].rightAnswers;
            }
        }

        public void SortImages(List<int> VV, List<int> VV1) //функция сортировки изображений --Ю
        {
            for (int i = 0; i < VV.Count; i++)
            {
                for (int j = 0; j < VV1.Count; j++)
                {
                    if (VV[i] == VV1[j])
                    {
                        int temp = VV1[i];
                        var temp1 = images[i];

                        VV1[i] = VV1[j];
                        VV1[j] = temp;

                        images[i] = images[j];
                        images[j] = temp1;
                    }
                }
            }
        }

        public void CreatePageTask(int n) //Создание страниц задач на основе введенных данных в специальный класс --Ю
        {
            HideElements();

            Task currTask = TaskArray[n];
            if (currTask.img != 0) //вывод изображения
            {
                pictureBox1.BackgroundImage = images[currTask.img - 1];
            }
            else
            {
                pictureBox1.BackgroundImage = null;
            }

            taskText_label.Text = currTask.textTask;

            if (radioButtons.Length >= currTask.radioButtons.Length && currTask.radioButtons != "") // проверяем хватает ли у нас кнопок для их выведения
            {
                for (int i = 0; i < currTask.radioButtons.Length; i++)
                {
                    radioButtons[i].Visible = true;
                    radioButtons[i].Text = currTask.radioButtons[i].ToString();
                }
            }

            if (currTask.isTexBox)
            {
                foreach(TextBox tb in TB)
                {
                    tb.Visible = true;
                }
            }

            if (!currTask.isTexBox)
            {
                if (answer[n] != 0)
                {
                    radioButtons[answer[n] - 1].Checked = true;
                }
                else
                {
                    for (int i = 0; i < currTask.radioButtons.Length; i++)
                    {
                        radioButtons[i].Checked = false;
                    }
                }
            }

            textBox1.Text = currTask.textOfTextBox;
        }

        public void HideElements ()                 //скрываем элементы выбора ответа --Ю
        {
            foreach (RadioButton rb in radioButtons)
            {
                rb.Visible = false;
            }
            foreach (TextBox tb in TB)
            {
                tb.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Show(0);
        }

        protected override void OnFormClosing(FormClosingEventArgs e) 
        {
            base.OnFormClosing(e);
            Application.Exit();
        }

        public void Show(int n)
        {
            int n1 = n + 1;
            label1.Text = "Вопрос №" + n1;
            CreatePageTask(n); //создаем сранички с заданиями --Ю
            //В последнем вопросе меняем текст кнопки "Вперед" на "Завершить тест"  --Ю
            if (n == answer.Length - 1)         
            {
                button2.Text = "Закончить тест";
            }
            else
            {
                button2.Text = "Вперед";
            }
        }
        //клик по кнопке Назад
        private void button1_Click(object sender, EventArgs e) 
        {
            if (TaskArray[n].isTexBox) //записываем результат ручного ввода ответа по нажатии на кнопку Назад --Ю
            {
                if (textBox1.Text != "")
                {
                    saveTextBoxMessage(int.Parse(textBox1.Text));
                }
            }
            n--;
            if (n < 0)
            {
                n = 0;
            }
            Show(n);
        }

        //Клик по кнопке Вперед
        private void button2_Click(object sender, EventArgs e)      
        {
            if (TaskArray[n].isTexBox) //записываем результат ручного ввода ответа по нажатии на кнопку Вперед --Ю
            {
                if (textBox1.Text != "")
                {
                    saveTextBoxMessage(int.Parse(textBox1.Text));
                }
            }
           
            n++;
            bool finish = false;

            //Проверка: ответил ли пользователь на все вопросы --Ю
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
                Show(n);
            }
        }


        //сохранение выбранного ответа на предыдущие вопросы --Ю
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked == true)
            {
                int i = int.Parse(rb.Name[rb.Name.Length - 1].ToString());
                answer[n] = i;
                TaskArray[n].checkedButton = i;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)  //допускается ввод только цифр -- Ю
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
            if (Char.IsControl(number))
            {
                e.Handled = false;
            }
        }   

        private void saveTextBoxMessage(int message) //запись ручного ввода ответа в текстбокс
        {
            answer[n] = message;
            TaskArray[n].textOfTextBox = answer[n].ToString();
        }

        private void finishTest()   //Метод, подсчитывающий результат -- Ю
        {
            //прячем лишнее
            ClearLabel();
            HideElements();
            label2.Visible = true;
            button1.Enabled = false;
            button2.Enabled = false;
            pictureBox1.Visible = false;

            double sumRightAns = 0;

            //считаем правильные ответы
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

            //Вывод результатов
            String sndc = Application.StartupPath + @"\Results.txt";
            string path = @"..\..\Data\Results.txt";
            System.IO.File.AppendAllText(path, " " + DateTime.Now + " Ваш IQ:" + iq + "\n \n");
            
           
            label2.Text = "Ваш IQ: \n"
                + iq.ToString("00.")+"\n";
            if(iq > 145)
            {
                label2.Text += "Еще чуть-чуть и вы Билл Гейтс";
            }
            else if(iq > 130 && iq <= 145)
            {
                label2.Text += "Ваш IQ как у Арнольда Шварценеггера или Мадонны)";
            }
            else if (iq > 90 && iq <= 130)
            {
                label2.Text += "Ваш IQ как у Аллы Пугачевой";
            }
            else if(iq > 70 && iq  <= 90)
            {
                label2.Text += "Ваш IQ как у Пэрис Хилтон";
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
        public void ClearLabel() //Финальная очистка Метки для Описания задачи
        {
            taskText_label.Text = "";
        }

    }  
}
