using System;
using System.Collections.Generic;
using System.Text;

namespace DentistryLab6
{
    class Dolznost
    {
		string title;       //Название должности
		string podrazdel;   //Подразделение, к которому относится должность	
		public Dolznost() { }      //Конструктор без параметров

		public string Title
		{
			get => title;
			set 
			{
				if (String.IsNullOrEmpty(value))
					throw new ArgumentNullException("Вы ввели пустую строку. Проверьте введенные данные для названия должности");
				else { title = value; } 
			}         
		}
		public string Podrazdel
		{
			get => podrazdel;
			set
			{
				if (String.IsNullOrEmpty(value))
					throw new ArgumentNullException("Вы ввели пустую строку. Проверьте введенные данные для подразделения должности");
				else { podrazdel = value; }
			}
		}
		public Dolznost(string Title, string Podrazdel) //Конструктор с параметрами
		{
			this.Title = Title;
			this.Podrazdel = Podrazdel;
		}
		public void input()     //Функция ввода
		{
			Console.WriteLine("Введите название должности: ");
			this.Title = Console.ReadLine();
			Console.WriteLine("Введите подразделение для должности: ");
			this.Podrazdel = Console.ReadLine();
		}
		public void output()   //Функция вывода
		{
			Console.WriteLine("Название должности: ");
			Console.WriteLine(this.Title);
			Console.WriteLine("Подразделение для должности: ");
			Console.WriteLine(this.Podrazdel);
		}
	}
}
