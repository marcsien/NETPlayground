using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace ParallelTasksExample
{
    class Program
    {
        static void Main(string[] args)
        {
            const int maxThreadAllowed = 64;
            var watch = new Stopwatch();
            // Klasa ManualResetEventSlim to lżejsza wersja klasy ManualResetEvent
            // Lżejszej wersji używamy dla krótkich operacji, gdzie blokada nie będzie trwała długo
            // ManualResetEvent używamy, gdy operacja będzie trwała długo a metoda WaitOne będzie
            // blokowała wątek przez długi czas
            // Klasa jest implemetacją po stronie jądra, a takie operacje, tj. .NET-kernel są zwykle bardzo dużym ociążaniem dla procesora i pamięci.
            // Jednym z przykładów użycia klasy jest oczekiwanie na zamknięcie przez pewien określony czas oraz przerwanie, jeżeli nie istnieje.
            // Przypadek taki może się zdarzyć, kiedy wątek utknie np. w tzw. deadlock'u - martwy punkt.
            var mres = new ManualResetEventSlim[maxThreadAllowed];
            for (int i = 0; i < mres.Length; i++)
            {
                // poniższy zapis pozwala na ustawienie stanu początkowego obiektu, w tym przypadku ustawiamy go na false dla każdego elementu
                // innymi słowy, początkowa wartość sygnału jest ustawiona na false
                mres[i] = new ManualResetEventSlim(false);
            }




            watch.Start();
            // uruchamiamy nowy klasyczny wątek (thread) oraz powiadamiamy ManualResetEvent kiedy wykonanie jest skończone
            // możemy więc sprawdzić czas wykonania
            for (int i = 0; i < mres.Length; i++)
            {
                var id = i;
                var thread = new Thread(state =>
                {
                    for (int j = 0; j < 10; j++)
                    {
                        Console.WriteLine(string.Format("Wątek: {0}, numer operacji: {1}", state.ToString(), j.ToString()));
                    }
                    // wysłamy zdarzenie za pomocą metody Set(), zmiana wartości sygnału, który pozwala by jeden lub więcej wątków oczekiwał ma wykonanie zdarzenia
                    mres[id].Set();
                });
                // Uruchamiany wykonanie danego wątku
                thread.Start(string.Format("Wątek: {0}", i));
            }
            // WaitHandle - mechanim pozwalający na kontrolę nad wykonaniem wątków
            // Oczekujemy, aż każdy element na liście otrzyma sygnał
            WaitHandle.WaitAll((from x in mres select x.WaitHandle).ToArray());
            // Zapisujemy czas wykonania klasycznego wątku
            var threadTime = watch.ElapsedMilliseconds;
            watch.Reset();






            foreach (ManualResetEventSlim t in mres)
            {
                // zmieniamy status zdarzenia na brak sygnału, powoduje to zablokowanie wątków
                t.Reset();
            }








            watch.Start();
            // Wykonujemy to samo zadanie, tym razem używając biblioteki Task Parallel Library
            for (int i = 0; i < mres.Length; i++)
            {
                var id = i;
                Task.Factory.StartNew(state =>
                {
                    for (int j = 0; j < 10; j++)
                    {
                        Console.WriteLine(string.Format("Wątek: {0}, numer operacji: {1}", state.ToString(), j.ToString()));
                    }
                    mres[id].Set();
                }, string.Format("Zadanie: {0}", i));
            }
            WaitHandle.WaitAll((from x in mres select x.WaitHandle).ToArray());
            // zapisujemy czas wykonania zadania
            var taskTime = watch.ElapsedMilliseconds;




            // wypisujemy czasy wykonania operacji
            Console.WriteLine("Tradycyjne podejście przy użyciu wątków: {0}ms", threadTime);
            Console.WriteLine("Podejście przy użyciu TPL: {0}ms", taskTime);
            foreach (var item in mres)
            {
                // zmieniamy status zdarzenia na brak sygnału, powoduje to zablokowanie wątków
                item.Reset();
            }
            Console.ReadKey();
        }
    }
}