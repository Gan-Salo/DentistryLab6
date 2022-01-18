using System;
using System.Collections.Generic;
using System.Text;

namespace DentistryLab6
{
    class Cabin<P> 
    {
        public P number { get; set; }

        public Cabin(P number)  //Конструктор с одним параметром
        {
            this.number = number;
        }

        public void Display()
        {
            Console.Write("\nНомер кабинета: " + number );
        }
    }
}
