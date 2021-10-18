using System;
using System.Collections.Generic;
using System.Text;

namespace DentistryLab6
{
    class Cabinet
    {
        int number;     //Номер кабинета
        string otdelen; //Отделение, в которое входит кабинет
        int area;		//Площадь кабинета                  
        public Cabinet()    //Конструктор без параметров
        {
            number = -1;
            otdelen = "Отделение №1";
            area = -1;
        }
        public Cabinet(int number, string otdelen, int area)    //Конструктор с параметрами
        {
            this.number = num_check(number);
            this.otdelen = otdelen;
            this.area = area;
        }  
        public int num_check(int number)
        {
            if (number > 0 && number < 1000)
            {
                return number;
            }
            else
            {
                Console.WriteLine("Ошибка. Номер кабинета задан неправильно.\n");
                return -1;
            }
        }
        public void input()     //Функция ввода
        {
            do
            {
                Console.WriteLine("Введите номер кабинета: ");
                try 
                { 
                    this.number = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ошибка. Введите номер от 1 до 1000\n");
                    number = -1;
                }
                
            } while (number < 0);
            Console.WriteLine("Введите отделение: ");
            this.otdelen = Console.ReadLine();
            Console.WriteLine("Введите площадь кабинета: ");
            this.area = Convert.ToInt32(Console.ReadLine());
            
        }
        public void output()   //Функция вывода
        {
            Console.WriteLine("Кабинет ");            
            Console.WriteLine("Номер: ");
            Console.WriteLine(this.number);
            Console.WriteLine("Отделение: ");
            Console.WriteLine(this.otdelen);
            Console.WriteLine("Площадь: ");
            Console.WriteLine(this.area);
        }  
        
    }

   
}
