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
                number = value; 
            }
        }
        public string Otdelen
        {
            get => otdelen;
            set
            {
               otdelen = value; 
            }
        }
        public int Area
        {
            get => area;
            set
            {
               area = value; 
            }
        }
        public Cabinet()    //Конструктор без параметров
        { 
        
        }

        public Cabinet(int number, string otdelen, int area)    //Конструктор с параметрами
        {
            this.number = number;
            this.otdelen = otdelen;
            this.area = area;
        }

        public void input()     //Функция ввода
        {

            do
            {
                Console.WriteLine("Введите номер кабинета: ");
                try
                {
                    number = Convert.ToInt32(Console.ReadLine());
                    if (number < 0)
                    {
                        throw new Exception("Данное значение не подходит для описания номера кабинета");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    number = -1;
                }

            } while (number == -1);

            do
            {
                Console.WriteLine("Введите отделение: ");              
                try
                { 
                    otdelen = Console.ReadLine();
                    if (String.IsNullOrEmpty(otdelen))
                    {                    
                        throw new Exception("Вы ввели пустую строку.");
                    }                                      
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                } 

            } while (otdelen == "");

            do
            {
                Console.WriteLine("Введите площадь кабинета: ");          
                try
                {
                    area = Convert.ToInt32(Console.ReadLine());
                    if (area < 0)
                    {
                        throw new Exception("Данное значение не подходит для описания площади кабинета");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    area = -1;
                }

            } while (area == -1);
        }
        public void output()   //Функция вывода
        {           
            Console.WriteLine("Номер кабинета: " + number + "; Отделение: " + otdelen + "; Площадь кабинета: " + area);
        }  
        
        public void fullarea(out int Areas)
        {         
            Areas = 0;
            Areas = this.area;
        }
    }
 
}
