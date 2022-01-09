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
		static int counter = 0;

	public string Fio
		{
			get => fio;

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
				else { fio = value; }
			}
		}
		public int Age
		{
			get => age;
			set
			{
				if (value < 0 && value > 120)
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
				else { age = value; }
			}
		}
		public string Phone
		{
			get => phone;
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
				else { phone = value; }
			}

		}

		//static Patient[] pat_massiv;
		public Patient()
		{
			counter++;
		}      //Конструктор без параметров
		public Patient(string fio, int age, string phone) //Конструктор с параметрами
		{
			this.fio = fio;
			this.age = age;
			this.phone = phone;
			counter++;
		}
		public void input()     //Функция ввода
		{
			

			do
			{				
				Console.WriteLine("Введите ФИО пациента: ");
				Fio = Console.ReadLine();
				
					try
					{
						throw new Exception("Вы ввели пустую строку.");
					}
					catch (Exception e)
					{
						Console.WriteLine(e.Message);
					}
				
			} while (String.IsNullOrEmpty(Fio));
			
			//if (String.IsNullOrEmpty(Fio))
			//{
			//	try
			//	{
			//		throw new Exception("Вы ввели пустую строку.");
			//	}
			//	catch (Exception e)
			//	{
			//		Console.WriteLine(e.Message);
			//	}
			//}

			Console.WriteLine("Введите возраст пациента: ");
			Age = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Введите телефон пациента: ");
			Phone = Console.ReadLine();
		}
		public void output()   //Функция вывода
		{

			if (counter >= 0)
			{
				Console.WriteLine("ФИО пациента: " + Fio + "; Возраст пациента: " + Age + "; Телефон пациента: " + Phone);
			}
			else
			{
				Console.WriteLine("Информация о коробке передач отсутствует");
			}
		}

		//public void pat_massiv(int co)
		////{
		////    Patient[] pat_massiv1 = new Patient[kolvo + 1];
		////    for (int i = 0; i < kolvo; i++)
		////    {
		////        pat_massiv1[i] = pat_massiv[i];
		////    }
		////    pat_massiv = pat_massiv1;
		//}


		//public void addto_pmass(Patient pat1)
		//{
		//	if (counter > 0)
		//	{
		//		Array.Resize(ref pat_mass, counter + 1);
		//	}
		//	pat_mass[counter] = pat1;
		//	counter++;

		//}


		//public void patmass_get()
		//{
		//	for (int i = 0; i < counter; i++)
		//	{
		//		pat_mass[i] = new Patient();
		//		Console.WriteLine();
		//		pat_mass[i].input();

		//	}
		//}


	}
}
