using System;
using System.Collections.Generic;
using System.Text;

namespace DentistryLab6
{
    class Dolznost
    {
		string title;       //Название должности
		string podrazdel;   //Подразделение, к которому относится должность	
		
		public string Title
		{
			get => title;
			set 
			{
				title = value; 
			}         
		}
		public string Podrazdel
		{
			get => podrazdel;
			set
			{
				podrazdel = value; 
			}
		}		
		public Dolznost() { }      //Конструктор без параметров

		public Dolznost(string Title) //Конструктор с одним параметром
        {
			this.Title = title;
		}
		public Dolznost(string Title, string Podrazdel) //Конструктор с параметрами
		{
			this.Title = title;
			this.Podrazdel = podrazdel;
		}
		public void input()     //Функция ввода
		{			
			do
			{
				Console.WriteLine("Введите название должности: ");
				try
				{
					title = Console.ReadLine();
					if (String.IsNullOrEmpty(title))
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
				Console.WriteLine("Введите подразделение для должности: ");
				try
				{
					podrazdel = Console.ReadLine();
					if (String.IsNullOrEmpty(podrazdel))
					{
						throw new Exception("Вы ввели пустую строку.");
					}
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
				}

			} while (podrazdel == "");
		}

		public static void get_labor()
        {
			Dolznost dolzn = new Dolznost();
			dolzn.Title = "Лаборант";
			dolzn.Podrazdel = "Мед. персонал";
		}
		public void output()   //Функция вывода
		{
			Console.WriteLine("Название должности: " + this.title + "; Подразделение для должности: " + this.podrazdel);
		}
	}
}
