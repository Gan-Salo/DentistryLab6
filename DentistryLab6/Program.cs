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
                Console.WriteLine("1) Лаборант\n2)Поле protected \n3)ToString и Display \n4)Обобщённый класс \n5)Коллекция и сортировка\n\nESC - выход");
                mainmenu = Console.ReadKey().KeyChar;

                switch (mainmenu)
                {
                    case 49:
                        {
                            /*Демонстрация работы с объектами производного класса*/
                            Console.Clear();
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("1) Ввод информации о докторе и лаборанте\n2) Работа конструкторов");
                                extramenu = Console.ReadKey().KeyChar;
                                Console.WriteLine("\n");
                            } while (extramenu != '1' && extramenu != '2');
                         

                            if (extramenu == '1')
                            {                                
                                Doctor doc1 = new Doctor();
                                doc1.input();
                                doc1.output();
                                
                                Laborant lab1 = new Laborant();
                                lab1.input();
                                lab1.output();
                            }
                            else
                            {
                                Dolznost dolz = new Dolznost("Лаборант", "-");                               
                                Doctor doc1 = new Doctor();
                                Laborant lab1 = new Laborant("wdw", 19, "434234234", dolz, "Обычная", 4);
                                lab1.output();
                                lab1.kurs_get();
                                lab1.kurs_set(3);
                                lab1.kurs_get();
                                
                                Laborant lab2 = new Laborant();
                                lab2.output();
                                lab2.Init("Тестовый", 20, "+94328349283", dolz, "Обычн", 3);
                                lab2.output();
                            }
                                                       
                            Console.WriteLine("\nНажмите любую клавишу для возврата в меню.");
                            Console.ReadKey(true);
                            break;
                        }

                    case 50:
                        {
                            /*Работа с полем с модификатором 'protected'*/
                            Console.Clear();
                            Dolznost dolz = new Dolznost("Стоматолог", "Стандарт");
                            Laborant lab1 = new Laborant("wdw", 19, "434234234", dolz, "Обычная", 5);
                            //lab1.dolznost.Title = "Тестовое название";
                            Console.WriteLine("\nДанные лаборанта до повышения:");
                            lab1.output();
                            Console.WriteLine("\nДанные лаборанта после повышения:");
                            lab1.doc_become("Хирург", "Мед. работники");
                            lab1.output();
                            Console.WriteLine("\nНажмите любую клавишу для возврата в меню.");
                            Console.ReadKey(true);
                            break;
                        }
                    case 51:
                        {
                            /*Работа с Display и ToString*/
                            Console.Clear();
                            Cabinet cab = new Cabinet();
                            cab.input();
                            cab.Display();

                            Console.WriteLine("\nВывод через ToString: " + cab.ToString());
                            Console.WriteLine("\nНажмите любую клавишу для возврата в меню.");
                            Console.ReadKey(true);
                            break;
                        }
                    case 52:
                        {
                            /*Работа с обобщённым классом*/
                            Console.Clear();
                            Patient[] pats = new Patient[3];
                            for (int i = 0; i < 3; i++)
                            {
                                pats[i] = new Patient();
                            }
                            Array<Patient> patsi = new Array<Patient>(pats);
                            patsi.input();
                            patsi.output();

                            Console.WriteLine("\nНажмите любую клавишу для возврата в меню.");
                            Console.ReadKey(true);
                            break;
                        }
                    
                }

            } while (mainmenu != 27);
        }
    }
}
