using System;
using System.Collections.Generic;
using System.Text;

namespace DentistryLab6
{
    interface PatDisplay
    {
        
        void interf() => Console.WriteLine("Кто-то решил записаться в стомоталогическую клинику!\nВот данные этого человека: ");
        void output();
    }
}
