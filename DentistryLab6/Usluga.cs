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
				{
					try
					{
						throw new Exception("Некорректное значение.");
					}
					catch (Exception e)
					{
						Console.WriteLine(e.Message);
					}

				}
				else { title = value; }				
			}
		}
		public int Cost
		{
			get => cost;
			set
			{
				if (value < 0)
				{
					try
					{
						throw new Exception("Некорректное значение.");
					}
					catch (Exception e)
					{
						Console.WriteLine(e.Message);
					}
				}
				else { cost = value; }
			}
		}
		public Usluga() { }      //Конструктор без параметров
		public Usluga(string title, int cost) //Конструктор с параметрами
		{
			this.title = title;
			this.cost = cost;
		}
		public void input()     //Функция ввода
		{
			Console.WriteLine("Введите название услуги: ");
			title = Console.ReadLine();
			Console.WriteLine("Введите стоимость услуги: ");
			cost = Convert.ToInt32(Console.ReadLine());
		}
		public void output()   //Функция вывода
		{
			Console.WriteLine("Название услуги: " + Title + "; Стоимость услуги: " + Cost);
		}
		public void fullcost(ref int Costs)
		{			
			Costs = Costs + this.cost;
		}
	}
}
