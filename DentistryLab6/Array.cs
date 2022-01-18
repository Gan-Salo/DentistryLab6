using System;
using System.Collections.Generic;
using System.Text;

namespace DentistryLab6
{
    class Array<P> where P : Patient
    {
        public P[] data;
        public int size;


        public Array(P[] pat)
        {
            data = pat;
            size = pat.Length;
        }

        public void input()
        {
            for (int i = 0; i < size; i++)
            {
                data[i].input();                
                Console.Write("\n");
            }
        }

        public void output()
        {
            for (int i = 0; i < size; i++)
            {
                data[i].output();
                Console.Write("\n");
            }
        }

    }
}
