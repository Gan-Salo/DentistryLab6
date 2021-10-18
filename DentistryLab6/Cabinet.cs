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
        { }

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
                    
                    this.number = Convert.ToInt32(Console.ReadLine());
                    
                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка. Номер кабинета задан неправильно.\n");
                    number = -1;
                    continue;
                }

                if (this.number < 0 || this.number > 1000)
                {
                    Console.WriteLine("Ошибка. Номер кабинета должен находиться в промежутке от 1 до 1000.\n");
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
