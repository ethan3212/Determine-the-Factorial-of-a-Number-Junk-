using System;
using static System.Console;

namespace Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            int junk = Factorial2(5);
            WriteLine("junk is:" + junk);
            ReadLine();
        }

        static int Factorial(int N)
        {
            if (N == 1)
                return N;
            else
            {
                int smaller = N - 1;
                int answer = Factorial(smaller);
                return (N * answer);
            }
        }
        static int Factorial2(int N)
        {
            int answer = N;

            for(int i=N-1; i>1; i--)
            {
                answer = answer * i;
            }

            return answer;
        }
    }
}
