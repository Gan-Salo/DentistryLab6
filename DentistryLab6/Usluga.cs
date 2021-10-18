using System;
using System.Collections.Generic;
using System.Text;

namespace DentistryLab6
{
    class Usluga
    {
		string title;   //Название услуги
		int cost;   //Стоимость услуги
		public Usluga() { }      //Конструктор без параметров
		public Usluga(string title, int cost) //Конструктор с параметрами
		{
			this.title = title;
			this.cost = cost;
		}
		public void input()     //Функция ввода
		{
			Console.WriteLine("Введите название должности: ");
			this.title = Console.ReadLine();
			Console.WriteLine("Введите подразделение для должности: ");
			this.cost = Convert.ToInt32(Console.ReadLine());
		}
		public void output()   //Функция вывода
		{
			Console.WriteLine("Название должности: ");
			Console.WriteLine(this.title);
			Console.WriteLine("Подразделение для должности: ");
			Console.WriteLine(this.cost);
		}
	}
}
