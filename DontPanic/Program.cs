using System;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm asendab kõik 'o' tähed lauses "Don't Panic" nulliga - 0;
            //programm asendab kõik 'a' tähed samas lauses 4-ga;

            string message = "Don't Panic";
            message = message.Replace('o', '0');
            message = message.Replace('a', '4');

            Console.WriteLine(message);
        }
    }
}
