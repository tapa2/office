using System;
using System.Collections.Generic;

namespace Office
{
    class Team
    {

        public string Name { get; set; }
        private List<Worker> Workers;


        public Team(string name)
        {
            Name = name;
            Workers = new List<Worker>();
        }


        public void AddWorker(Worker worker)
        {
            Workers.Add(worker);
        }


        public void ShowTeamInfo()
        {
            Console.WriteLine($"Команда: {Name}");
            foreach (var worker in Workers)
            {
                Console.WriteLine(worker.Name);
            }
        }

        public void ShowDetailedTeamInfo()
        {
            Console.WriteLine($"Команда: {Name}");
            foreach (var worker in Workers)
            {
                Console.WriteLine($"{worker.Name} - {worker.Position} - {worker.WorkDay}");
            }
        }
    }
}