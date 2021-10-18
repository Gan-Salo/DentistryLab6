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
		
		public Doctor() { }      //Конструктор без параметров

		public string Fio
		{
			get => fio;
			set => fio = value;
		}
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
			
			Console.WriteLine("Введите ФИО доктора: ");
			this.fio = Console.ReadLine();
			Console.WriteLine("Введите возраст доктора: ");
			this.age = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Введите телефон доктора: ");
			this.phone = Console.ReadLine();
			this.dolznost.input();
			Console.WriteLine("Введите категорию доктора: ");
			this.kategory = Console.ReadLine();
		}
		public void output()   //Функция вывода
		{
			Console.WriteLine("ФИО доктора: ");
			Console.WriteLine(this.fio);
			Console.WriteLine("Возраст доктора: ");
			Console.WriteLine(this.age);
			Console.WriteLine("Телефон доктора: ");
			Console.WriteLine(this.phone);
			Console.WriteLine("Название должности: ");
			Console.WriteLine(this.dolznost.Title);
			Console.WriteLine("Подразделение для должности: ");
			Console.WriteLine(this.dolznost.Podrazdel);
			Console.WriteLine("Категория доктора: ");
			Console.WriteLine(this.kategory);
		}
	}
}
