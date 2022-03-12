using System;
using System.Collections.Generic;

namespace Yeald1
{
    class Program
    {
        static List<int> MyList = new List<int>();
        static void Main(string[] args)
        {
            // wypełniamy naszą listę danymi
            FillMyList();
            // wywołujemy pętle foreach na naszej metodzie, która zwraca jedynie liczby większe niż 3
            foreach (var item in ListWithYieldReturn())
            {
                // wyświetlamy wartości, które spełniają warunek przez nas zdefiniowany
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
        static void FillMyList()
        {
            MyList.Add(1);
            MyList.Add(2);
            MyList.Add(3);
            MyList.Add(4);
            MyList.Add(5);
        }
        static IEnumerable<int> ListWithYieldReturn()
        {
            // Przechodzimy po elementach naszej listy
            foreach (var item in MyList)
            {
                // kontrolka do caller'a (metody wywołującej) jest przekazywana jeżeli warunek jest spełniony
                if (item > 3)
                    yield return item;
            }
        }
    }
}
