using System;
using System.Collections.Generic;
using System.Text;

namespace DentistryLab6
{
	class Patient : PatDisplay, ICloneable
	{
		string fio;     //ФИО
		int age;        //Возраст
		string phone;   //Номер телефона
		static int counter = 0; //Количество пациентов

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
		
		public Patient()	//Конструктор без параметров
		{
			counter++;
		}
		public Patient(string fio) //Конструктор с одним параметром
		{
			this.fio = fio;
			counter++;
		}
		public Patient(string fio, int age, string phone) //Конструктор с параметрами
		{
			this.fio = fio;
			this.age = age;
			this.phone = phone;
			counter++;
		}

		public object Clone()
		{
			return new Patient(fio, age, phone);
		}

		public void input()     //Функция ввода
		{
			
			do
			{				
				Console.WriteLine("Введите ФИО пациента: ");				
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
				Console.WriteLine("Введите возраст пациента: ");
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
				Console.WriteLine("Введите телефон пациента: ");
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
			counter++;

		}
		public void output()   //Функция вывода
		{

			if (counter >= 0)
			{
				Console.WriteLine("ФИО пациента: " + fio + "; Возраст пациента: " + age + "; Телефон пациента: " + phone);
			}
			else
			{
				Console.WriteLine("Информация о коробке передач отсутствует");
			}
		}

		/*Функция установления определённого количества пациентов*/
		public static void set_counter(int kolvo)
		{
			counter = kolvo;
		}

		/*Функция вывода количества пациентов*/
		public static void get_counter()
		{
			Console.WriteLine(counter);
		}

	}
}
