using System;
using System.Collections.Generic;
using System.Text;

namespace DentistryLab6
{
    class Doctor  
    {
		string fio;         //ФИО
		int age;            //Возраст
		string phone;       //Номер телефона
		Dolznost dolznost = new Dolznost();        //Название должности
		string kategory;    //Категория	
		public string Fio
		{
			get => fio;
			set 
			{ 
				fio = value; 
			}
			
		}
		public int Age
		{
			get => age;
			set
			{
				age = value; 
			}
		}
		public string Phone
		{
			get => phone;
			set
			{
				phone = value; 
			}
		}

		public string Kategory
		{
			get => kategory;
			set
			{
				kategory = value;
			}
		}

		public Doctor() { }      //Конструктор без параметров

		public Doctor(string fio, int age, string phone, Dolznost dolznost, string kategory)
		{
			this.fio = fio;
			this.age = age;
			this.phone = phone;
			this.dolznost = dolznost;
			this.kategory = kategory;
		}

		public void input()     //Функция ввода
		{			

			do
			{
				Console.WriteLine("Введите ФИО доктора: ");
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
				Console.WriteLine("Введите возраст доктора: ");
				try
				{
					age = Convert.ToInt32(Console.ReadLine());
					if (age < 0)
					{
						throw new Exception("Данное значение не подходит для описания номера кабинета");
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
				Console.WriteLine("Введите телефон доктора: ");
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
				Console.WriteLine("Введите категорию доктора: ");
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
		}
		public void output()   //Функция вывода
		{
			Console.WriteLine("ФИО доктора: " + fio + "; Возраст доктора: " + age + "; Телефон доктора: " + phone + ";\n" + "Название должности: " + dolznost.Title + "; Подразделение для должности: " + dolznost.Podrazdel + "; Категория доктора: " + kategory);
		}
	}
}
