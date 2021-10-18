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
				if (String.IsNullOrEmpty(value))
					throw new ArgumentNullException("Вы ввели пустую строку. Проверьте введенные данные для ФИО доктора.");
				else { fio = value; }
			}
		}
		public int Age
		{
			get => age;
			set
			{
				if (value < 0 && value > 120)
					throw new ArgumentOutOfRangeException("Ошибка. Данное значение не подходит для описания возраста доктора.");
				else { age = value; }
			}
		}
		public string Phone
		{
			get => phone;
			set
			{
				if (String.IsNullOrEmpty(value))
					throw new ArgumentNullException("Вы ввели пустую строку. Проверьте введенные данные для номера телефона доктора.");
				else { phone = value; }
			}
		}

		public string Kategory
		{
			get => kategory;
			set
			{
				if (String.IsNullOrEmpty(value))
					throw new ArgumentNullException("Вы ввели пустую строку. Проверьте введенные данные для номера категории доктора.");
				else { kategory = value; }
			}
		}

		public Doctor() { }      //Конструктор без параметров

		public Doctor(string fio, int age, string phone, Dolznost dolznost, string kategory)
		{
			this.fio = Fio;
			this.age = Age;
			this.phone = Phone;
			this.dolznost = dolznost;
			this.kategory = Kategory;
		}

		public void input()     //Функция ввода
		{			
			Console.WriteLine("Введите ФИО доктора: ");
			Fio = Console.ReadLine();
			Console.WriteLine("Введите возраст доктора: ");
			Age = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Введите телефон доктора: ");
			Phone = Console.ReadLine();
			dolznost.input();
			Console.WriteLine("Введите категорию доктора: ");
			Kategory = Console.ReadLine();
		}
		public void output()   //Функция вывода
		{
			Console.WriteLine("ФИО доктора: " + Fio + "; Возраст доктора: " + Age + "; Телефон доктора: " + Phone + ";\n" + "Название должности: " + dolznost.Title + "; Подразделение для должности: " + dolznost.Podrazdel + "; Категория доктора: " + Kategory);
		}
	}
}
