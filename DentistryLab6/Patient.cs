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
		public Patient() { }      //Конструктор без параметров
		public Patient(string fio, int age, string phone) //Конструктор с параметрами
		{
			this.fio = fio;
			this.age = age;
			this.phone = phone;
		}
		public void input()     //Функция ввода
		{
			Console.WriteLine("Введите ФИО пациента: ");
			this.fio = Console.ReadLine();
			Console.WriteLine("Введите возраст пациента: ");
			this.age = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Введите телефон пациента: ");
			this.phone = Console.ReadLine();
		}
		public void output()   //Функция вывода
		{
			Console.WriteLine("ФИО пациента: ");
			Console.WriteLine(this.fio);
			Console.WriteLine("Возраст пациента: ");
			Console.WriteLine(this.age);
			Console.WriteLine("Телефон пациента: ");
			Console.WriteLine(this.phone);
		}

	}
}
