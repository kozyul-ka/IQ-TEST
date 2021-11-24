using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тест_на_IQ
{
    class Task
    {
        public int img;
        public string textTask;
        public string radioButtons;
        public int rightAnswers;
        public bool isTexBox;
        public int checkedButton = 0;
        public string textOfTextBox = "";

        public Task() { }
        public Task(int im, string tt, string rb, bool isT, int rA)
        {
            this.img = im;
            this.textTask = tt;
            this.radioButtons = rb;
            this.rightAnswers = rA;
            this.isTexBox = isT;
        }

    }
}
