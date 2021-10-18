using System;
using System.Collections.Generic;
using System.Text;

namespace DentistryLab6
{
    class Zapis
    {
        Usluga usluga = new Usluga();        //Название услуги
        Doctor doctor = new Doctor();        //Врач
        Patient patient = new Patient();        //Пациент	
        Cabinet cabinet = new Cabinet();        //Номер кабинета приёма
        string date;		//Дата и время приема

        public string Date
        {
            get => date;
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Вы ввели пустую строку. Проверьте введенные данные для названия должности");
                else { date = value; }
            }
        }
        public Zapis() { }    //Конструктор без параметров
        public Zapis(Usluga usluga, Doctor doctor, Patient patient, Cabinet cabinet, string date)       //Конструктор с параметрами
        {
            this.usluga = usluga;
            this.doctor = doctor;
            this.patient = patient;
            this.cabinet = cabinet;
            this.date = date;
        }
		public void input()     //Функция ввода
		{
			this.usluga.input();
			this.doctor.input();
			this.patient.input();
			this.cabinet.input();
			Console.WriteLine("Введите дату приема: ");
			this.date = Console.ReadLine();
		}
		public void output()   //Функция вывода
		{
            this.usluga.output();
            this.doctor.output();
            this.patient.output();
            this.cabinet.output();
            this.doctor.output();
            Console.WriteLine("Дата приёма: " + this.date);
        }
	}
}
