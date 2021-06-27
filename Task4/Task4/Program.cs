using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = 999999999;
            //ініціалізація списку, значення якого зберігаються в heap
            List<long> list = new List<long>() { };
            for (int i = 0; i < number; i++)
            {
                //додаємо елементи до списку
                //так як треба додати number елементів то heap заб'єтсья
                //Виникне помилка OutOfMemoryException
                list.Add(number);
            }
        }
        
    }
}
