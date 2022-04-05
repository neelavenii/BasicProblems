using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basicproblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to basic problems");
            Swap swap = new Swap();
            Swap.SwapNumbers();
            EvenOdd evenOdd = new EvenOdd();
            EvenOdd.CheckEvenOdd();
            VowelConsonant vowelConsonant = new VowelConsonant();
            VowelConsonant.Charactor();
            Harmonic harmonic = new Harmonic();
            Harmonic.HarmonicNumbers();


            Console.ReadLine();
        }
    }
} 
