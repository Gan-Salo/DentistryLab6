using System;


namespace DentistryLab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();          
            int mainmenu, extramenu, opmenu;

            do
            {
                Console.Clear();
                Console.WriteLine("1) Кабинет\n2) Демонстрация свойств полей\n3) Массив объектов\n4) ref и out\n5) Перегрузка операторов\n6) Обработка строк\n7) Статические поле и метод\n8) Массив объектов с одним параметром\n9) Двойной массив объектов\nESC - выход");
                mainmenu = Console.ReadKey().KeyChar;

                switch (mainmenu)
                {
                    case 49:
                        {
                            /*Демонстрация работы с объектами класса, при ручном вводе предусмотрены защиты*/
                            Console.Clear();
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("1) Ввод информации о кабинете\n2) Работа конструкторов");
                                extramenu = Console.ReadKey().KeyChar;
                                Console.WriteLine("\n");
                            } while (extramenu != '1' && extramenu != '2');

                            Cabinet cab = new Cabinet(12, "2323", 222);
                            Cabinet cab1 = new Cabinet(12, "2323", 222);
                            Cabinet cab2 = new Cabinet(124);
                            Cabinet cab3 = new Cabinet();

                            if (extramenu == '1')
                            {
                                cab.input();                                
                                cab.output(); 
                            }
                            else
                            {                               
                                cab1.output();
                                cab2.output();
                                cab3.output();

                            }
                                                       
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
                            /*Работа с массивом объектов*/
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

                            /*Ввод массива*/
                            for (int i = 0; i < n; i++)
                            {
                                pat_mass[i] = new Patient();
                                pat_mass[i].input();
                            }

                            /*Вывод массива*/
                            for (int i = 0; i < n; i++)
                            {                              
                                pat_mass[i].output();
                            }
                            Console.ReadKey(true); 
                            break;
                        }

                    case 52:
                        {
                            /*ref и out*/
                            Console.Clear();
                            int Areas;
                            Cabinet cab3 = new Cabinet(203, "dd", 21);                            
                            cab3.fullarea(out Areas);                          
                            Console.WriteLine("\nОбщая площадь (out): " + Areas);

                            /*ref - */
                            int Costs = 13;
                            Usluga usl3 = new Usluga("dsd", 210);                           
                            usl3.fullcost(ref Costs);
                            Console.WriteLine("\nОбщая стоимость (ref): " + Costs);
                            Console.ReadKey(true);
                            break;
                        }

                    case 53:
                        {
                            /*Перегрузка операторов*/
                            Console.Clear();
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("1) Оператор сложения\n2) Постфиксный оператор \n3) Префиксный оператор\n");
                                opmenu = Console.ReadKey().KeyChar;
                                Console.WriteLine("\n");
                            } while (opmenu < '1' && opmenu > '3');

                            /*Оператор сложения - складывает стоимость услуг*/
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
                            /*Постфиксный оператор*/
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
                            /*Префиксный оператор*/
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
                            /*Работа со строками*/
                            Console.Clear();
                            string test, testusl = "Чистка зубов";                           
                            Usluga usl1 = new Usluga("fisrt", 2100);

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
                            /*Статическое поле создается в одном экземпляре независимо от объектов класса, будет существовать до выхода из функции main*/
                            Console.Clear();
                            Patient testpat = new Patient();
                            Console.Write("\nКоличество пациентов после добавления одного объекта: ");
                            /*Статические методы хранят состояние всего класса, а не конкретного объекта*/
                            Patient.get_counter();
                            Console.Write("\nКоличество пациентов после установки количества пациентов на 3: ");
                            Patient.set_counter(3);
                            Patient.get_counter();
                            Patient testpat2 = new Patient();
                            Console.Write("\nКоличество пациентов после добавления ещё одного объекта: ");
                            Patient.get_counter();
                            Console.ReadKey(true);
                            break;
                        }
                    case 56:
                        {
                            /*Инициализация массива объектов конструктором с одним параметром*/
                            Console.Clear();
                            Console.Write("Массив пациентов с одним параметром (ФИО): \n");                                                     
                            Patient[] pat_mass = new Patient[3];
                            
                            /*Ввод массива*/
                            for (int i = 0; i < 3; i++)
                            {
                                pat_mass[i] = new Patient("Тестовый пациент №" + (i + 1));
                            }

                            /*Вывод массива*/
                            for (int i = 0; i < 3; i++)
                            {
                                pat_mass[i].output();
                            }
                            Console.ReadKey(true);
                            break;
                        }
                    case 57:
                        {
                            /*Работа с двойным массивом объектов и массивом массивов объектов*/
                            Console.Clear();                           
                            int n,k;
                            do
                            { 
                                Console.Write("Введите количество строк массива: ");
                                n = Convert.ToInt32(Console.ReadLine());
                                if (n < 0)
                                {
                                    Console.Write("Введено неверное значение.");
                                }
                            } while (n < 0);
                           
                            do
                            {
                                Console.Write("Введите количество столбцов массива: ");
                                k = Convert.ToInt32(Console.ReadLine());
                                if (k < 0)
                                {
                                    Console.Write("Введено неверное значение.");
                                }
                            } while (k < 0);


                            /*Двумерный массив - элементы явл. значениями типа Patient. Кол-во элементов внутри строго задано, размерность массивов всегда одинакова*/
                            Patient[,] pat_mass = new Patient[n,k];
                            
                            /*Ввод массива*/
                            for (int i = 0; i < n; i++)
                            {
                                for (int j = 0; j < k; j++)
                                {
                                    pat_mass[i, j] = new Patient();
                                    pat_mass[i, j].input();
                                }
                            }

                            /*Вывод массива - элементы явл. ссылками на массив типа Patient. Внутренние размерности не заданы, массивы внутри могут быть неравномерными и включать разное кол-во объектов*/
                            for (int i = 0; i < n; i++)
                            {
                                for (int j = 0; j < k; j++)
                                {
                                    pat_mass[i, j].output();
                                }
                            }
                            
                            /*Массив массивов*/
                            Patient[][] pat_mass2 = new Patient[3][];
                            pat_mass2[0] = new Patient[3];
                            
                            for (int j = 0; j < 3; j++)
                            {                              
                                Console.Write("Строка №1,  Столбец: " + (j + 1) + "\n");
                                pat_mass2[0][j] = new Patient("Тестовый пациент", 21, "+123912312");                               
                            }
                            Patient.output_mass(pat_mass2[0], 3);

                            pat_mass2[1] = new Patient[1];
                            for (int j = 0; j < 1; j++)
                            {
                                Console.Write("Строка №2,  Столбец: " + (j + 1) + "\n");
                                pat_mass2[1][j] = new Patient("Тестовый пациент", 21, "+123912312");
                            }
                            Patient.output_mass(pat_mass2[1], 1);

                            pat_mass2[2] = new Patient[2];
                            for (int j = 0; j < 2; j++)
                            {
                                Console.Write("Строка №3,  Столбец: " + (j + 1) + "\n");
                                pat_mass2[2][j] = new Patient("Тестовый пациент", 21, "+123912312");
                            }              
                            Patient.output_mass(pat_mass2[2], 2);

                            Console.ReadKey(true);
                            break;
                        }
                }

            } while (mainmenu != 27);
        }
    }
}
