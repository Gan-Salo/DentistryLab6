using System;
using System.Collections.Generic;
using System.Text;

namespace DentistryLab6
{
    class Patient
    {		
		string fio;     //ФИО
		int age;        //Возраст
		string phone;   //Номер телефона	
		public string Fio
		{
			get => fio;
			set
			{
				if (String.IsNullOrEmpty(value))
					throw new ArgumentNullException("Вы ввели пустую строку. Проверьте введенные данные для ФИО пациента");
				else { fio = value; }
			}
		}
		public int Age
		{
			get => age;
			set
			{
				if (value < 0 && value > 120)
					throw new ArgumentOutOfRangeException("Ошибка. Данное значение не подходит для описания возраста пациента.");
				else { age = value; }
			}
		}
		public string Phone
		{
			get => phone;
			set
			{
				if (String.IsNullOrEmpty(value))
					throw new ArgumentNullException("Вы ввели пустую строку. Проверьте введенные данные для номера телефона пациента");
				else { phone = value; }
			}
		}
		public Patient() { }      //Конструктор без параметров
		public Patient(string fio, int age, string phone) //Конструктор с параметрами
		{
			this.fio = Fio;
			this.age = Age;
			this.phone = Phone;
		}
		public void input()     //Функция ввода
		{
			Console.WriteLine("Введите ФИО пациента: ");
			Fio = Console.ReadLine();
			Console.WriteLine("Введите возраст пациента: ");
			Age = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Введите телефон пациента: ");
			Phone = Console.ReadLine();
		}
		public void output()   //Функция вывода
		{
			Console.WriteLine("ФИО пациента: " + Fio + "; Возраст пациента: " + Age + "; Телефон пациента: " + Phone);
		}

	}
}
