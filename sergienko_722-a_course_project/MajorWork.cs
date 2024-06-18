using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sergienko_722_a_course_project
{
    internal class MajorWork
    {
        private string Data; 
        private string Result; 
                               
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
    
