using System;
using System.IO; 

namespace LR
{
    class Program
    {
        static void Main(string[] args)
        {
            LR a = new LR("input.txt");

            a.ReadData();
            a.ProcessData();
            a.ShowResults();
        }
    }
}
