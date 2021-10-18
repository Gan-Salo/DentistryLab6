using System;


namespace DentistryLab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Cabinet test_cab = new Cabinet(-12, "wdwd", 333);
            //test_cab.input();
            test_cab.output();
        }
    }
}
