using System;


namespace DentistryLab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Patient pat = new Patient();
            Cabinet cab = new Cabinet(12, "2323", 222);
            int mainmenu, extramenu, opmenu;

            do
            {
                Console.Clear();
                Console.WriteLine("1) Кабинет\n2) Демонстрация свойств полей\n3) Массив объектов\n4) ref и out\n5) Перегрузка оператора '+'\n\nESC - выход");
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
                            Console.WriteLine("\nНажмите любую клавишу для возврата в меню.");
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
                            Console.WriteLine("\nНажмите любую клавишу для возврата в меню.");
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
                            break;
                        }

                    case 52:
                        {
                            Console.Clear();
                            int Areas;
                            Cabinet cab3 = new Cabinet(203, "dd", 21);                            
                            cab3.fullarea(out Areas);                          
                            Console.WriteLine("\nОбщая площадь (out): " + Areas);

                            int Costs = 0;
                            Usluga usl3 = new Usluga("dsd", 210);                           
                            usl3.fullcost(ref Costs);
                            Console.WriteLine("\nОбщая стоимость (ref): " + Costs);
                            Console.ReadKey(true);
                            break;
                        }

                    case 53:
                        {
                            Console.Clear();
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("1) Оператор сложения\n2) Префиксный оператор\n3) Постфиксный оператор\n");
                                opmenu = Console.ReadKey().KeyChar;
                                Console.WriteLine("\n");
                            } while (opmenu < '1' && opmenu > '3');

                            if (opmenu == '1')
                            {
                                Console.Clear();
                                Usluga usl1 = new Usluga("fisrt", 2100);
                                Usluga usl2 = new Usluga("second", 1500);
                                Usluga usl3 = new Usluga("third");
                                Console.WriteLine("\nПервая услуга: ");
                                usl1.output();
                                Console.WriteLine("\nВторая услуга: ");
                                usl2.output();
                                usl3 = usl1 + usl2;
                                Console.WriteLine("\nТретья услуга: ");
                                usl3.output();
                                Console.ReadKey(true);
                            }
                            else if (opmenu == '2')
                            {
                                Console.Clear();
                                Usluga usl1 = new Usluga("fisrt", 2100);
                                Usluga usl2 = new Usluga("second");                              
                                Console.WriteLine("\nПервая услуга до: ");
                                usl1.output();                                                             
                                usl2 = usl1++;
                                Console.WriteLine("\nПервая услуга после: ");
                                usl1.output();
                                Console.WriteLine("\nВторая услуга после: ");
                                usl2.output();
                                Console.ReadKey(true);
                            }
                            else if (opmenu == '3')
                            {
                                Console.Clear();
                                Usluga usl1 = new Usluga("fisrt", 2100);
                                Usluga usl2 = new Usluga("second");
                                Console.WriteLine("\nПервая услуга до: ");
                                usl1.output();                               
                                usl2 = ++usl1;
                                Console.WriteLine("\nПервая услуга после: ");
                                usl1.output();
                                Console.WriteLine("\nВторая услуга после: ");
                                usl2.output();
                                Console.ReadKey(true);

                            }
                            
                            Console.WriteLine("\nНажмите любую клавишу для возврата в меню.");
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
