using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office
{
    class Manager : Worker
    {

        private Random random = new Random();

        public Manager(string name) : base(name)
        {
            Position = "Менеджер";
        }

        public override void FillWorkDay()
        {

            for (int i = 0; i < random.Next(1, 11); i++)
            {
                Call();
            }

            Relax();

            for (int i = 0; i < random.Next(1, 6); i++)
            {
                Call();
            }
        }
    }
}