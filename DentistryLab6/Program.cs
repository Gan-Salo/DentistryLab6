﻿using System;


namespace DentistryLab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Patient pat = new Patient();
            Cabinet cab = new Cabinet(12, "2323", 222);
            int mainmenu, extramenu;

            do
            {
                Console.Clear();
                Console.WriteLine("1) Кабинет\n2) Демонстрация свойств полей\n3) Массив объектов\n\nESC - выход");
                mainmenu = Console.ReadKey().KeyChar;

                switch (mainmenu)
                {
                    case 49:
                        {
                            Console.Clear();
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("1) Ввод информации о кабинете\n2) Добавление кабинета с заранее введёнными данными");
                                extramenu = Console.ReadKey().KeyChar;
                                Console.WriteLine("\n");
                            } while (extramenu != '1' && extramenu != '2');
                            
                            if (extramenu == '1')
                            {
                                cab.input();
                                Console.Clear();
                            }
                            else
                            {
                                cab.Number = -200;
                                cab.Otdelen = "Общее";
                                cab.Area = 45;
                               
                            }
                            cab.output();                            
                            Console.WriteLine("\n\nНажмите любую клавишу для возврата в меню.");
                            Console.ReadKey(true);
                            break;
                        }
                    case 50:
                        {
                            Patient pat1 = new Patient();                            
                            Patient pat2 = new Patient("dwd", 12, "rr");

                            Console.Clear();
                            pat1.Fio = "Тест Семен Семенович";
                            pat1.Age = 23;
                            pat1.Phone = "89832190809";
                            pat1.output();
                            pat2.output();
                            pat2 = pat1;
                            pat1.output();
                            Console.WriteLine("\n\nНажмите любую клавишу для возврата в меню.");
                            Console.ReadKey(true);
                            break;
                        }

                    case 51:
                        {
                            Console.Clear();
                            Console.Write("Введите количество коробок передач для создания массива: ");
                            int n;
                            do
                            {
                                n = Convert.ToInt32(Console.ReadLine());
                                if (n < 0)
                                {
                                    Console.Write("Неверно введено значение, попробуйте еще: ");
                                }
                            } while (n < 0);
                            
                            Patient[] pat_mass = new Patient[n];

                            for (int i = 0; i < n; i++)
                            {
                                pat_mass[i] = new Patient();
                                pat_mass[i].input();
                            }

                            for (int i = 0; i < n; i++)
                            {                              
                                pat_mass[i].output();
                            }
                            Console.ReadKey(true);
                        }
                        break;

                }

            } while (mainmenu != 27);



            //Cabinet test_cab = new Cabinet();
            //test_cab.input();
            
            //test_cab.output();
        }
    }
}
