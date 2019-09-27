using System;

namespace MethodsHW
{
    class ProgramMethods
    {
        static void Main(string[] args)
        {
            var program = new ProgramMethods();
            program.newMethod();
            program.banana(9f, 3.3f);
            program.banana(12f, 4f);

            int[] luckyNums = { 4, 5, 6, 1, 2, 7, 9, 10 };
            program.final(luckyNums);
        }

        public void newMethod()
        {
            Console.WriteLine("something");
        }

        public void banana(float buddy, float guy)
        {
            var avg = buddy + guy / 2;
            Console.WriteLine(avg);
        }

        public void final(int[] param3)
        {
            foreach(int x in param3)
            {
                if(x == 7)
                {
                    Console.WriteLine("Lucky you!");
                }
            }
        }
    }
}
