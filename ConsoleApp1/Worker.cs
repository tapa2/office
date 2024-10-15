using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office
{
    abstract class Worker
    {

        public string Name { get; set; }
        public string Position { get; set; }
        public string WorkDay { get; protected set; }

        public Worker(string name)
        {
            Name = name;
        }

        public void Call()
        {
            WorkDay += $"{Name} робить дзвінок.\n";
        }

        public void WriteCode()
        {
            WorkDay += $"{Name} пише код.\n";
        }

        public void Relax()
        {
            WorkDay += $"{Name} відпочиває.\n";
        }

        public abstract void FillWorkDay();
    }
}
