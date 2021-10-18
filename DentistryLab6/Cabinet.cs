using System;
using System.Collections.Generic;
using System.Text;

namespace DentistryLab6
{
    class Cabinet
    {
        int number;     //Номер кабинета
        string otdelen; //Отделение, в которое входит кабинет
        int area;       //Площадь кабинета                  
        
        public int Number
        {
            get => number;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Ошибка. Данное значение не подходит для описания номера кабинета.");
                else { number = value; }
            }
        }
        public string Otdelen
        {
            get => otdelen;
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Вы ввели пустую строку. Проверьте введенные данные для названия отделения кабинета.");
                else { otdelen = value; }
            }
        }
        public int Area
        {
            get => area;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Ошибка. Данное значение не подходит для описания площади кабинета.");
                else { area = value; }
            }
        }
        public Cabinet()    //Конструктор без параметров
        { }

        public Cabinet(int number, string otdelen, int area)    //Конструктор с параметрами
        {
            this.number = Number;
            this.otdelen = Otdelen;
            this.area = Area;
        }  
        
        public void input()     //Функция ввода
        {           
            Console.WriteLine("Введите номер кабинета: ");
            Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите отделение: ");
            Otdelen = Console.ReadLine();
            Console.WriteLine("Введите площадь кабинета: ");
            Area = Convert.ToInt32(Console.ReadLine());            
        }
        public void output()   //Функция вывода
        {           
            Console.WriteLine("Номер кабинета: " + Number + "; Отделение: " + Otdelen + "; Площадь кабинета: " + Area);
        }  
        
    }
 
}
