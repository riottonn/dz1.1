using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Worker
    {
        public string Name { get; set; }
        public string Position { get; protected set; }
        public StringBuilder WorkDay { get; private set; }

        public Worker(string name)
        {
            Name = name;
            WorkDay = new StringBuilder();
        }

        public void Call()
        {
            WorkDay.Append(" Call;");
        }

        public void WriteCode()
        {
            WorkDay.Append(" Writing code;");
        }

        public void Relax()
        {
            WorkDay.Append(" Rest;");
        }

        public abstract void FillWorkDay();

        public override string ToString()
        {
            return $"{Name} - {Position} - {WorkDay}";
        }
    }
}
