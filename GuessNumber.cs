using System;
namespace guessnumber
{
    class GuessNumber
    {
        static void Main()
        {
            bool INFINITE = true;
            while (INFINITE)
            {
                Console.Title = "GuessNumber.. ";
                Random Rand = new Random();
                int Min = 1, Max = 100, Count = 0, WrongCount = 1;
                int Num = Rand.Next(Min, Max);
                string Output = "SUCCESS! Answer: {0}";
                //Console.Title += Num;
                while (true)
                {
                    Console.Write("Type number ({0}-{1}): ",Min,Max);
                    int Input = Convert.ToInt32(Console.ReadLine());
                    Min = Input < Num ? Input : Min;
                    Max = Input > Num ? Input : Max;
                    if (Input == Num) { break; }
                    Count++;
                }
                if (Count > WrongCount) { Output = "FAILD, Correct Answer: {0}｜Conut: {1}"; }
                Console.WriteLine("\n" + Output, Num, Count + 1);
                Console.Write("\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
