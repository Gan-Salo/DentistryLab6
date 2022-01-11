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
                Console.WriteLine("1) Лаборант 2)Поле protected\n\nESC - выход");
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
                                
                            }
                            else
                            {                               
                                Doctor doc1 = new Doctor();
                                Laborant lab1 = new Laborant("wdw", 19, "434234234", 4);
                                lab1.output();
                                lab1.kurs_get();
                                lab1.kurs_set(3);
                                lab1.kurs_get();

                            }
                                                       
                            Console.WriteLine("\nНажмите любую клавишу для возврата в меню.");
                            Console.ReadKey(true);
                            break;
                        }

                    case 50:
                        {
                            /*Работа с полем с модификатором 'protected'*/
                            Console.Clear();

                            Laborant lab1 = new Laborant("Вася", 21, "+79821231232", 5);
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
                }

            } while (mainmenu != 27);
        }
    }
}
