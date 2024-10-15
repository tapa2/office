using System;

namespace Office
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Team team = new Team("Dream Team");

            Developer dev1 = new Developer("Олексій");
            Manager manager1 = new Manager("Іван");

            team.AddWorker(dev1);
            team.AddWorker(manager1);


            dev1.FillWorkDay();
            manager1.FillWorkDay();

            team.ShowTeamInfo();


            team.ShowDetailedTeamInfo();
        }
    }
}