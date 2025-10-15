using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp1.manager;

namespace ConsoleApp1
{
    internal class program
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                List<Team> teams = new List<Team>();

                while (true)
                {
                    Console.WriteLine("\n=== MENU ===");
                    Console.WriteLine("1. Create a new team ");
                    Console.WriteLine("2. Add a worker to the team");
                    Console.WriteLine("3. Show information about all teams");
                    Console.WriteLine("4. Show more information about all teams");
                    Console.WriteLine("5. Exit");
                    Console.Write("Select a request: ");

                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            Console.Write("Name the team: ");
                            string teamName = Console.ReadLine();
                            teams.Add(new Team(teamName));
                            Console.WriteLine($"The team '{teamName}' was created!");
                            break;

                        case "2":
                            if (teams.Count == 0)
                            {
                                Console.WriteLine("Create one team for work!");
                                break;
                            }

                            Console.WriteLine("Select a request: ");
                            for (int i = 0; i < teams.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {teams[i].Name}");
                            }

                            int teamIndex;
                            if (!int.TryParse(Console.ReadLine(), out teamIndex) || teamIndex < 1 || teamIndex > teams.Count)
                            {
                                Console.WriteLine("Wrong team choice :(");
                                break;
                            }

                            Team selectedTeam = teams[teamIndex - 1];

                            Console.Write("Enter the name of worker: ");
                            string name = Console.ReadLine();

                            Console.WriteLine("Choose their position:");
                            Console.WriteLine("1. Developer");
                            Console.WriteLine("2. Manager");

                            string pos = Console.ReadLine();
                            Worker newWorker;

                            if (pos == "1")
                                newWorker = new Developer(name);
                            else if (pos == "2")
                                newWorker = new Manager(name);
                            else
                            {
                                Console.WriteLine("Wrong position :(");
                                break;
                            }

                            newWorker.FillWorkDay();
                            selectedTeam.AddWorker(newWorker);

                            Console.WriteLine($"The worker {name} has been added to the team '{selectedTeam.Name}'!");
                            break;

                        case "3":
                            if (teams.Count == 0)
                            {
                                Console.WriteLine("No teams created!");
                                break;
                            }
                            foreach (var t in teams)
                                t.ShowTeamInfo();
                            break;

                        case "4":
                            if (teams.Count == 0)
                            {
                                Console.WriteLine("No teams created!");
                                break;
                            }
                            foreach (var t in teams)
                                t.ShowDetailedInfo();
                            break;

                        case "5":
                            Console.WriteLine("Program is over!");
                            return;

                        default:
                            Console.WriteLine("Wrong request, try again :(");
                            break;
                    }
                }
            }
        }
    }
}
