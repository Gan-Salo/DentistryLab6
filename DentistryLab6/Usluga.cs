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
				title = value; 				
			}
		}
		public int Cost
		{
			get => cost;
			set
			{
				cost = value; 
			}
		}
		public Usluga() { }      //Конструктор без параметров

		public Usluga(string title) //Конструктор с одним параметром
		{ 
			this.title = title; 
		}
		public Usluga(string title, int cost) //Конструктор с параметрами
		{
			this.title = title;
			this.cost = cost;
		}
		public void input()     //Функция ввода
		{		
			do
			{
				Console.WriteLine("Введите название услуги: ");
				try
				{
					title = Console.ReadLine();
					if (title == "")
					{
						throw new Exception("Вы ввели пустую строку.");
					}
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
				}

			} while (title == "");

			do
			{
				Console.WriteLine("Введите стоимость услуги: ");
				try
				{
					cost = Convert.ToInt32(Console.ReadLine());
					if (cost < 0)
					{
						throw new Exception("Данное значение не подходит для описания стоимости услуги");
					}
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
					cost = -1;
				}

			} while (cost == -1);
		}
		public void output()   //Функция вывода
		{
			Console.WriteLine("Название услуги: " + Title + "; Стоимость услуги: " + Cost);
		}
		public void fullcost(ref int Costs)
		{			
			Costs = Costs + this.cost;
		}
		public static Usluga operator +(Usluga usl1, Usluga usl2)
		{
			Usluga newcost = new Usluga();
			newcost = usl1;
			newcost.cost = newcost.cost + usl2.cost;
			//newcost.rab_obem = newcost.rab_obem + mot2.rab_obem;
			return newcost;
		}

		public static Usluga operator ++(Usluga usl1)
		{
			Usluga newcost = new Usluga();
			newcost.cost = usl1.cost + 1;
			//newcost.rab_obem = newcost.rab_obem + mot2.rab_obem;
			return newcost;
		}

	}
}
