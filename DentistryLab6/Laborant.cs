using System;
using System.Collections.Generic;
using System.Text;

namespace DentistryLab6
{
    class Laborant : Doctor
    {
        public int kurs;
        public void kurs_set(int kurs1)
        {            
            this.kurs = kurs1;
        }
        
        public void kurs_get()
        {
            Console.WriteLine("\nУчебный курс лаборанта: " + this.kurs);
        }
        
        public Laborant(string fio, int age, string phone, int kurs)
        {
            Fio = fio;
            Age = age;
            Phone = phone;
            dolznost.Title = "Лаборант";
            dolznost.Podrazdel = "Мед. персонал";
            Kategory = "-";
            this.kurs = kurs;
        }

        public void doc_become(string title, string podrazd)
        {
            dolznost.Title = title;
            dolznost.Podrazdel = podrazd;
        }


    }
}
