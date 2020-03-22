using System;

class Program
{
    static void Main(string[] args)
    {
        string g1 = "XY";
        string g2 = "XX";
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write(g1[i]);
                Console.Write(g2[j]);
            }
        }
    }
}
