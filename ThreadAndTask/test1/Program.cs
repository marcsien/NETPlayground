using System;
using System.Diagnostics;
using System.Threading.Tasks;
namespace ParallelExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ustawiamy rozmiary naszych tablic.
            // Zwiększ liczbę elementów aby lepiej zobaczyć porównanie uzyskanych rezultatów
            int colCounter = 800;
            int rowCounter = 800;
            // tworzymy dwuwymiarowe tablice
            double[,] m1 = InitializeMatrix(rowCounter, colCounter);
            double[,] m2 = InitializeMatrix(rowCounter, colCounter);
            // tworzymy tablicę wynikową. Będzie ona rezultatem mnożenia obu tablic
            var result = new double[rowCounter, colCounter];
            // W pierwszej kolejności wykonamy tradycyjne podejście
            Console.WriteLine("Tradycyjne wykonanie... \nOperacja ta chwilę potrwa...");
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            // mnożenie naszych tablic
            MultiplyTables(m1, m2, result);
            stopwatch.Stop();
            Console.WriteLine("Czas operacji: {0}ms", stopwatch.ElapsedMilliseconds);
            // resetujemy stoper oraz tworzymy nową tablicę wyników
            stopwatch.Reset();
            Console.WriteLine("Podejście równoległe...");
            result = new double[rowCounter, colCounter];
            stopwatch.Start();
            MultiplyTablesParallel(m1, m2, result);
            Console.WriteLine("Czas operacji: {0}ms", stopwatch.ElapsedMilliseconds);
            stopwatch.Stop();
            Console.ReadKey();
            // Wynik działania programu dla 800 kolumn i wierszy
            // Tradycyjne wykonanie...
            // Operacja ta chwile potrwa...
            // Czas operacji: 11136ms
            // Podejscie równolegle...
            // Czas operacji: 5046ms
        }
        private static void MultiplyTablesParallel(double[,] m1, double[,] m2, double[,] result)
        {
            // zwracamy liczbe kolumn we wskazanym wymiarze
            int m1Columns = m1.GetLength(1);
            int m2Columns = m2.GetLength(1);
            int resultColumns = result.GetLength(0);
            // Wykonany dokładnie tą samą operację ale przy użyciu biblioteki TPL
            Parallel.For(0, m1Columns, i =>
            {
                for (int j = 0; j < m2Columns; j++)
                {
                    // zmienna tymczasowa pozwoli na optymalizację równległych obliczeń
                    double temp = 0;
                    for (int k = 0; k < m1Columns; k++)
                    {
                        temp += m1[i, k] * m2[k, j];
                    }
                    result[i, j] = temp;
                }
            });
        }
        private static void MultiplyTables(double[,] m1, double[,] m2, double[,] result)
        {
            // zwracamy liczbe kolumn we wskazanym wymiarze
            int m1Columns = m1.GetLength(1);
            int m2Columns = m2.GetLength(1);
            int resultColumns = result.GetLength(0);
            for (int i = 0; i < m1Columns; i++)
            {
                for (int j = 0; j < m2Columns; j++)
                {
                    // zmienna tymczasowa pozwoli na optymalizację obliczeń
                    double temp = 0;
                    for (int k = 0; k < m1Columns; k++)
                    {
                        temp += m1[i, k] * m2[k, j];
                    }
                    result[i, j] = temp;
                }
            }
        }
        private static double[,] InitializeMatrix(int rowCounter, int colCounter)
        {
            var table = new double[rowCounter, colCounter];
            // klasa dzięki, której możemy generować liczby losowe
            var r = new Random();
            for (int i = 0; i < rowCounter; i++)
            {
                for (int j = 0; j < colCounter; j++)
                {
                    // liczba losowa, gdzie maksymalna wartość jest mniejsza niż 100
                    table[i, j] = r.Next(100);
                }
            }
            return table;
        }
    }
}