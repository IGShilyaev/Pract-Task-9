using System;

namespace Pract_Task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDList<double> list = new MyDList<double>();

            list.AddtoBegin(100);
            list.AddtoBegin(-100);
            list.AddtoEnd(8);
            list.AddtoEnd(10);
            list.AddtoEnd(0);
            list.AddtoEnd(-6.784);
            list.AddtoBegin(1.86);
            list.AddtoPosition(37.74, 3);

            Console.WriteLine("Вычисление суммы рекурсивно:");
            Console.WriteLine(DListSumRek(list.Beg, 0));
            Console.WriteLine("Вычисление суммы не рекурсивно:");
            Console.WriteLine(DListSum(list));
        }

        static double DListSum(MyDList<double> list)
        {
           
            if (list.Length == 0)
            {
                Console.WriteLine("Список пустой");
                return 0;
            }
            double res = 0;
            foreach (double number in list)  res += number; 
            return res;
        }

        static double DListSumRek(Point<double> p, double tekRes)
        {
            if (p == null)
            {
                Console.WriteLine("Список пустой");
                return 0;
            }
            tekRes += p.data;
            if (p.next == null) return tekRes;
            return DListSumRek(p.next, tekRes);
        }

    }
}
