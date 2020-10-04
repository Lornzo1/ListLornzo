using System;
using System.Collections.Generic;
namespace ListsLorenzo
{
    class Program
    {
        // i use this function several times so it thought it best to creat a standalone funciton
        static int ListLength(List<int> i)
        {
            int c = 0;
            foreach (int t in i)
            {
                c += 1;
            }
            return c;
        }
        //as this is one question I wanted to incorporate all parts into one funciton
        static int list_analyser(List<int> i)
        {
            int iSum = 0;
            float Avg = 0.0f;
            int iMax = 0;
            int iMin = Int32.MaxValue;
            // the Int32.Maxvalue ensures that my threshold is not below the actual minimum of the list
            List<int> t = new List<int> { };
            foreach (int iElement in i)
            {
                iSum = iSum + iElement;
                if (iElement > iMax)
                {
                    iMax = iElement;
                }
                if (iElement < iMin)
                {
                    iMin = iElement;
                }
                if (iElement < 0)
                {
                    t.Add(iElement);
                }
            }
            Avg = iSum / ListLength(i);
            Console.WriteLine(Avg);
            Console.WriteLine(iSum);
            Console.WriteLine(iMin);
            t.ForEach(Console.Write);
            Console.WriteLine(' ');// I had to include this line to ensure that iMax wasn't returned on teh same line as the negative integars
            return iMax;
        }
        static bool listComparer(List<int> i, List<int> t)
        {
            if (ListLength(i) != ListLength(t))
            {
                return false;
            }
            foreach (int iElement in i)
            {
                bool a = false;
                foreach (int tElement in t)
                {
                    if (tElement == iElement)
                    {
                        a = true;
                    }
                }
                if (a == false)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(list_analyser(new List<int> { 1, 5, 8, -4, 8, -2 }));
        }
    }
}

