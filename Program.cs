using System;

namespace zadanie2
{
    class Program
    {
        class Solution
        {
            public static int[] solution(int[] tab, int rotations)
            {
                for (int j = 0; j < rotations; j++)
                {
                    int bufor = tab[tab.Length - 1];
                    for (int i = tab.Length - 1 ; i > 0; i--)
                    {
                        tab[i] = tab[i - 1];
                    }
                    tab[0] = bufor;

                }
                return tab;
            }

        }
        static void Main(string[] args)
        {
            int[] tab = { 3, 8, 9, 7, 6 };
            int r = 3;
            tab = Solution.solution(tab, r);
            for(int i = 0; i < tab.Length; i++)
            {
                Console.Write($"{tab[i] } ");
            }
            Console.WriteLine();

        }
    }
}
