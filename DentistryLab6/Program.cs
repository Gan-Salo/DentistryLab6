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
                Console.WriteLine("1) Кабинет\n2) Демонстрация свойств полей\n3) Массив объектов\n4) ref и out\n5) Перегрузка операторов\n6) Обработка строк\n7) Статические поле и метод\nESC - выход");
                mainmenu = Console.ReadKey().KeyChar;

                switch (mainmenu)
                {
                    case 49:
                        {
                            Console.Clear();
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("1) Ввод информации о кабинете\n2) Добавление кабинета с уже введёнными данными");
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
                            Console.Clear();
                            Patient pat1 = new Patient();                            
                            Patient pat2 = new Patient("dwd", 12, "rr");                            
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
                            Console.Write("Введите количество пациентов для создания массива: ");
                            int n;
                            do
                            {
                                n = Convert.ToInt32(Console.ReadLine());
                                if (n < 0)
                                {
                                    Console.Write("Введено неверное значение.");
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
                            break;                        
                        }

                    case 54:
                        {
                            Console.Clear();
                            int comp;
                            string test, testusl = "Чистка зубов";                           
                            Usluga usl1 = new Usluga("fisrt", 2100);
                            Usluga usl2 = new Usluga("second", 1500);

                            usl1.Title = usl1.Title + " " + testusl; //Объединение строк
                            Console.Write("Объединение строк:");
                            Console.WriteLine(usl1.Title);
                            test = string.Concat(usl1.Title, "(ускоренная)");
                            Console.WriteLine(test);

                            Console.WriteLine("\nРазделение строк на массив подстрок:");
                            string[] words = test.Split(new char[] { ' ' }); //Разделение строк на массив подстрок с помощью функции split
                            foreach (string s in words)
                            {
                                Console.WriteLine(s);
                            }

                            Console.Write("\nВставка одной строки в другую:");
                            string substring = "(xxxd)";   //Вставка одной строки в другую с помощью функции Insert
                            test = test.Insert(6, substring); //Первым параметром в функции Insert является индекс, по которому надо вставлять подстроку, а второй параметр - подстрока
                            Console.WriteLine(test);

                            Console.Write("\nСмена регистра строки:");
                            Console.WriteLine(test.ToUpper()); //Смена регистра строки

                            Console.Write("\nУдаление последних 12 символов из строки:");
                            int ind = test.Length - 12; //Удаление последних 12 символов из строки
                            test = test.Remove(ind);
                            Console.WriteLine(test);
                            Console.ReadKey(true);
                            break;
                        }
                    case 55:
                        {
                            /*Статические методы получения и установки количества пациентов*/
                            Console.Clear();
                            Patient testpat = new Patient();
                            Patient.get_counter();
                            Patient.set_counter(3);
                            Patient.get_counter();
                            Patient testpat2 = new Patient();
                            Patient.get_counter();
                            Console.ReadKey(true);
                            break;
                        }

                }

            } while (mainmenu != 27);



            //Cabinet test_cab = new Cabinet();
            //test_cab.input();
            
            //test_cab.output();
        }
    }
}
