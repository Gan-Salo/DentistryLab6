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
                Console.WriteLine("1)Лаборант \n2)Поле protected \n3)ToString и Display \n4)Обобщённый класс \n5)Работа с интерфейсом \n6)Коллекция и сортировка \n7)Клонирование\n\nESC - выход");
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
                                
                                /*Пример полиморфизма: методы input и output для дочернего и родительского класса различаются с учетом доп. данного в классе 'Laborant'*/
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
                            /*Работа с Display и ToString (пример наследования от класса Object)*/
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
                            /*Работа с обобщённым классом (изменяет свое поведение в зависимости от приписываемого им типа. Этот тип указывается в квадратных скобках[] сразу после имени класса)*/
                            Console.Clear();  
                            Cabin<string> cab = new Cabin<string>("d123");
                            Cabin<int> cab2 = new Cabin<int>(345);
                            cab.Display();
                            cab2.Display();

                            Console.WriteLine("\nНажмите любую клавишу для возврата в меню.");
                            Console.ReadKey(true);
                            break;
                        }
                    case 53:
                        {
                            /*Работа с интерфейсом (класс может наследоваться от нескольких интерфейсов - отличие от абстрактного класса; интерфейс позволяет */
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
                            /*Демонстрация работы абстрактного класса и метода */
                            Console.Clear();
                            Dolznost dolz = new Dolznost("Стоматолог", "Стандарт");
                            Doctor doc = new Doctor("Овсянников Г.В.", 19, "+213091829038", dolz, "Высшая");
                            Patient pat1 = new Patient("Локеев Г.В.", 17, "+213091829038");
                            doc.GoToClinic();
                            pat1.GoToClinic();
                            Console.ReadKey(true);
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
