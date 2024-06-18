﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace sergienko_722_a_course_project
{
    internal class MajorWork
    {
        private System.DateTime TimeBegin;
        private string Data; 
        private string Result;
        public bool Modify;
        private int Key;

        private string SaveFileName;// ім’я файлу для запису
        private string OpenFileName;// ім’я файлу для читання
        public void WriteSaveFileName(string S)// метод запису даних в об'єкт
        {
            this.SaveFileName = S;// запам'ятати ім’я файлу для запису
        }
        public void SaveToFile() // Запис даних до файлу
        {
            if (!this.Modify)
                return;
            try
            {
                Stream S; // створення потоку
                if (File.Exists(this.SaveFileName))// існує файл?
                    S = File.Open(this.SaveFileName, FileMode.Append);// Відкриття файлу для збереження
                else
                    S = File.Open(this.SaveFileName, FileMode.Create);// створити файл
                Buffer D = new Buffer(); // створення буферної змінної
                D.Data = this.Data;
                D.Result = Convert.ToString(this.Result);
                D.Key = Key;
                BinaryFormatter BF = new BinaryFormatter(); 
                
                S.Flush(); // очищення буфера потоку
                S.Close(); // закриття потоку
                this.Modify = false; // Заборона повторного запису
            }
            catch
            {

                MessageBox.Show("Помилка роботи з файлом"); 
               
            }
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
                this.Modify = true;
            }
        }
    }
}
    
