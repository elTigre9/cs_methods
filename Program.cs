using System;

namespace MethodsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var prog = new Program();
            prog.myMethod1();

            int returnedValue = prog.myMethod2();

            Console.WriteLine(returnedValue);

            prog.myMethod3(27, 5);
            prog.myMethod3(400, 89);

            string[] zooAnimals = { "Cat", "Dog", "lion", "frog", "zebra", "peacock" };
            prog.loopMethod(zooAnimals);
        }

        public void myMethod1()
        {
            Console.WriteLine("method success!");
        }

        public int myMethod2()
        {
            Console.WriteLine("method 2 success!");
            return 9;
        }

        public void myMethod3(int param1, int param2)
        {
            var outcome = param1 / param2;
            Console.WriteLine(outcome);
        }

        public void loopMethod(string[] toLoop)
        {
            foreach(string x in toLoop)
            {
                if(x == "zebra")
                {
                    Console.WriteLine("Zebra!");
                } else if (x == "lion")
                {
                    Console.WriteLine("Lion!");
                } else
                {
                    Console.WriteLine("boring animal");
                }
            }
        }
    }
}
