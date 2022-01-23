using System;
using System.Collections.Generic;
using System.Text;

namespace DentistryLab6
{
    class Laborant : Doctor
    {
        private int kurs;
        public void kurs_set(int kurs1)
        {            
            this.kurs = kurs1;
        }
        
        public void kurs_get()
        {
            Console.WriteLine("\nУчебный курс лаборанта: " + this.kurs);
        }

        public Laborant()
        {
            
        }

        public Laborant(string fio, int kurs) : base(fio)
        {         
            this.kurs = kurs;
        }

        public Laborant(string fio, int age, string phone, Dolznost dolznost, string kategory, int kurs) : base(fio, age, phone, dolznost, kategory)
        {            
            this.kurs = kurs;
        }

        public void Init(string fio, int age, string phone, Dolznost dolznost, string kategory)
        {
            this.Fio = fio;
            this.Age = age;
            this.Phone = phone;
            this.dolznost = dolznost;
            this.Kategory = kategory;           
        }

        public void Init(string fio, int age, string phone, Dolznost dolznost, string kategory, int kurs)
        {
            this.Init(fio, age, phone, dolznost, kategory);
            this.kurs = kurs;
        }

        public void doc_become(string title, string podrazd)
        {
            dolznost.Title = title;
            dolznost.Podrazdel = podrazd;
        }

		new public void input()     //Функция ввода
		{

			do
			{
				Console.WriteLine("Введите ФИО лаборанта: ");
				try
				{
					fio = Console.ReadLine();
					if (String.IsNullOrEmpty(fio))
					{
						throw new Exception("Вы ввели пустую строку.");
					}
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
				}

			} while (fio == "");

			do
			{
				Console.WriteLine("Введите возраст лаборанта: ");
				try
				{
					age = Convert.ToInt32(Console.ReadLine());
					if (age < 0)
					{
						throw new Exception("Данное значение не подходит для описания возраста лаборанта");
					}
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
					age = -1;
				}

			} while (age == -1);

			do
			{
				Console.WriteLine("Введите телефон лаборанта: ");
				try
				{
					phone = Console.ReadLine();
					if (String.IsNullOrEmpty(phone))
					{
						throw new Exception("Вы ввели пустую строку.");
					}
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
				}

			} while (phone == "");
			dolznost.input();

			do
			{
				Console.WriteLine("Введите категорию лаборанта: ");
				try
				{
					Kategory = Console.ReadLine();
					if (String.IsNullOrEmpty(Kategory))
					{
						throw new Exception("Вы ввели пустую строку.");
					}
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
				}

			} while (Kategory == "");

			do
			{
				Console.WriteLine("Введите курс лаборанта: ");
				try
				{
					kurs = Convert.ToInt32(Console.ReadLine());
					if (kurs < 0)
					{
						throw new Exception("Данное значение не подходит для описания курса лаборанта");
					}
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
					kurs = -1;
				}

			} while (kurs == -1);
		}

		new  public void output()   //Функция вывода
		{
			Console.WriteLine("\nФИО доктора: " + fio + "; Возраст доктора: " + age + "; Телефон доктора: " + phone + ";\n" + "Название должности: " + dolznost.Title + "; Подразделение для должности: " + dolznost.Podrazdel + "; Категория доктора: " + kategory + "; Курс лаборанта: " + kurs);
		}

		override public string ToString()   //Функция вывода
		{
			return "\nФИО доктора: " + fio + "; Возраст доктора: " + age + "; Телефон доктора: " + phone + ";\n" + "Название должности: " + dolznost.Title + "; Подразделение для должности: " + dolznost.Podrazdel + "; Категория доктора: " + kategory + "; Курс лаборанта: " + kurs;
		}

	}
}
