using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sergienko_722_a_course_project
{
    internal class MajorWork
    {
        private System.DateTime TimeBegin;
        private string Data; 
        private string Result;

        private string SaveFileName;// ім’я файлу для запису
        private string OpenFileName;// ім’я файлу для читання


        public void WriteSaveFileName(string S)// метод запису даних в об'єкт
        {
            this.SaveFileName = S;// запам'ятати ім’я файлу для запису
        }
        public void WriteOpenFileName(string S)
        {
            this.OpenFileName = S;// запам'ятати ім’я файлу для відкриття
        }
       

        public void SetTime() 
        {
            this.TimeBegin = System.DateTime.Now;
        }
        public System.DateTime GetTime()
        {
            return this.TimeBegin;
        }

        public void Write(string D)// метод запису даних в об'єкт.
        {
            this.Data = D;
        }
        public string Read()
        {
            return this.Result;
        }
        public void Task() // метод реалізації програмного завдання
        {
            {
                if (this.Data.Length > 5)
                {
                    this.Result = Convert.ToString(true);

                }
                else
                {
                    this.Result = Convert.ToString(false);
                }
            }
        }
    }
}
    
