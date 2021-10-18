using System;
using System.Collections.Generic;
using System.Text;

namespace DentistryLab6
{
    class Usluga
    {
		string title;   //Название услуги
		int cost;   //Стоимость услуги
		public string Title
		{
			get => title;
			set
			{
				if (String.IsNullOrEmpty(value))
					throw new ArgumentNullException("Вы ввели пустую строку. Проверьте введенные данные для названия услуги");
				else { title = value; }
			}
		}
		public int Cost
		{
			get => cost;
			set
			{
				if (value < 0)
					throw new ArgumentOutOfRangeException("Ошибка. Данное значение не подходит для описания цены услуги.");
				else { cost = value; }
			}
		}
		public Usluga() { }      //Конструктор без параметров
		public Usluga(string title, int cost) //Конструктор с параметрами
		{
			this.title = Title;
			this.cost = Cost;
		}
		public void input()     //Функция ввода
		{
			Console.WriteLine("Введите название услуги: ");
			Title = Console.ReadLine();
			Console.WriteLine("Введите стоимость услуги: ");
			Cost = Convert.ToInt32(Console.ReadLine());
		}
		public void output()   //Функция вывода
		{
			Console.WriteLine("Название услуги: " + Title + "; Стоимость услуги: " + Cost);
		}
	}
}
