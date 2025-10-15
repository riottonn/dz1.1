using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class manager
    {
        public class Manager : Worker
        {
            private Random random;

            public Manager(string name) : base(name)
            {
                Position = "Manager";
                random = new Random();
            }

            public override void FillWorkDay()
            {
                int firstCalls = random.Next(1, 11); // від 1 до 10
                for (int i = 0; i < firstCalls; i++)
                    Call();

                Relax();

                int secondCalls = random.Next(1, 6); // від 1 до 5
                for (int i = 0; i < secondCalls; i++)
                    Call();
            }
        }
    }
}
