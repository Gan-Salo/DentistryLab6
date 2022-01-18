using System;
using System.Collections.Generic;
using System.Text;

namespace DentistryLab6
{
    class Laborant : Doctor
    {
        private int kurs;
        public void kurs_set(int kurs1)
        {            
            this.kurs = kurs1;
        }
        
        public void kurs_get()
        {
            Console.WriteLine("\nУчебный курс лаборанта: " + this.kurs);
        }

        public Laborant()
        {
            
        }

        public Laborant(string fio, int kurs) : base(fio)
        {         
            this.kurs = kurs;
        }

        public Laborant(string fio, int age, string phone, Dolznost dolznost, string kategory, int kurs) : base(fio, age, phone, dolznost, kategory)
        {            
            this.kurs = kurs;
        }

        public void Init(string fio, int age, string phone, Dolznost dolznost, string kategory)
        {
            this.Fio = fio;
            this.Age = age;
            this.Phone = phone;
            this.dolznost = dolznost;
            this.Kategory = kategory;           
        }

        public void Init(string fio, int age, string phone, Dolznost dolznost, string kategory, int kurs)
        {
            this.Init(fio, age, phone, dolznost, kategory);
            this.kurs = kurs;
        }

        public void doc_become(string title, string podrazd)
        {
            dolznost.Title = title;
            dolznost.Podrazdel = podrazd;
        }


    }
}
