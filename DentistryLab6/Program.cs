using System;
using System.Collections;
using System.Linq;
using System.Text;

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
                Console.WriteLine("1) Лаборант\n2)Поле protected \n3)ToString и Display \n4)Обобщённый класс \n5)Работа с интерфейсом \n6)Коллекция и сортировка \n7)Клонирование\n\nESC - выход");
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
                            Cabin<string> cab = new Cabin<string>("d123");
                            Cabin<int> cab2 = new Cabin<int>(345);
                            cab.Display();
                            cab2.Display();

                            //Doctor[] doc = new Doctor[3];
                            //for (int i = 0; i < 3; i++)
                            //{
                            //    doc[i] = new Doctor();
                            //}
                            //Array<Doctor> docs = new Array<Doctor>(doc);
                            //docs.input();
                            //docs.output();

                            Console.WriteLine("\nНажмите любую клавишу для возврата в меню.");
                            Console.ReadKey(true);
                            break;
                        }
                    case 53:
                        {
                            /*Работа с интерфейсом*/
                            Console.Clear();
                            PatDisplay pat = new Patient("Овсянников Г.В.", 19, "+213091829038");
                            pat.interf();
                            pat.output();

                            Console.WriteLine("\nНажмите любую клавишу для возврата в меню.");
                            Console.ReadKey(true);
                            break;
                        }
                    case 54:
                        {
                            /*Работа с коллекциями и сортировкой*/
                            Console.Clear();
                            Dolznost dolz = new Dolznost("Стоматолог", "Стандарт");
                            ArrayList docs = new ArrayList();

                            Doctor doc = new Doctor("Овсянников Г.В.", 19, "+213091829038", dolz, "Высшая");
                            Doctor doc2 = new Doctor("dwwd", 24, "+83742384293", dolz, "Высшая");                         
                            Laborant lab1 = new Laborant("wdw", 20, "434234234", dolz, "Обычная", 5);

                            docs.Add(doc);
                            docs.Add(doc2);
                            docs.Add(lab1);

                            Console.Write("Коллекция до сортировки:\n\n");
                            foreach (Doctor dc in docs)
                            {
                                dc.output();
                                Console.Write("\n");
                            }

                            Console.Write("\nКоллекция после сортировки:\n\n");
                            docs.Sort();
                            foreach (Doctor dc in docs)
                            {
                                dc.output();
                                Console.Write("\n");
                            }

                            Console.WriteLine("\nНажмите любую клавишу для возврата в меню.");
                            Console.ReadKey(true);
                            break;
                        }
                    case 55:
                        {
                            /*Работа с клонированием*/
                            Console.Clear();
                            Patient pat1 = new Patient("Овсянников Г.В.", 19, "+213091829038");
                            Patient pat2 = new Patient();
                            pat1.output();
                            pat2.output();
                            pat2 = (Patient)pat1.Clone();

                            pat1.output();
                            pat2.output();
                            Console.ReadKey(true);
                            break;
                        }
                    case 56:
                        {
                            
                            break;
                        }
                    case 57:
                        {
                            
                            break;
                        }
                }

            } while (mainmenu != 27);
        }
    }
}
