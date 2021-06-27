using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            //значення масиву в heap, в стеку знаходиться посилання на значення в heap
            int[] arr = new int[3] { 1, 2, 3 };
            //видалямо посилання на масив в heap
            arr = null;
            //відбудеться помилка NullReferenceException
            Console.WriteLine(arr[1]);
        }
    }
}
