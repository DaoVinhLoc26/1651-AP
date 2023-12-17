using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManagementSystem
{
   
        class Program
        {
            private static bool found;

            static void Menu()
            {
                Console.WriteLine("----------------------");
                Console.WriteLine("1. Create new Player");
                Console.WriteLine("2. List of Players");
                Console.WriteLine("3. Search Player by name");
                Console.WriteLine("4. Delete Player");
                Console.WriteLine("5. Exit");
                Console.WriteLine("----------------------");
                Console.Write("Please choose an option: ");
            }

            static void Main(string[] args)
            {
                Club<APlayer> club = new Club<APlayer>();

                int opt = 0;
                while (opt != 5)
                {
                    Menu();
                    try
                    {
                        opt = int.Parse(Console.ReadLine());
                    
                        switch (opt)
                        {
                            case 1:
                                Player player = new Player();
                                club.Add(player);
                                break;
                            case 2:
                                Console.WriteLine("List of players:");
                                if (club.PlayerList.Count == 0)
                                {
                                    Console.WriteLine("No players!");
                                }
                                else
                                {
                                    Console.WriteLine("Name |   Age |   Attack  |   Defense |   Stamina |   Speed   |   Power");
                                    foreach (APlayer player1 in club)
                                    {
                                        player1.GetInfo();
                                    }
                                }
                                break;
                            case 3:
                                if (club.PlayerList.Count == 0)
                                {
                                    Console.WriteLine("No players!");
                                }
                                else
                                {
                                    Console.Write("Input player name you want to search: ");
                                    string name = Console.ReadLine();
                                    bool found = false;
                                    foreach (APlayer player1 in club)
                                    {
                                        if (name.Equals(player1.Name))
                                        {
                                            player1.GetInfo();
                                            found = true;
                                        }
                                    }
                                    if (!found)
                                    {
                                        Console.WriteLine("The name {0} is not found!", name);
                                    }
                                }
                                break;
                            case 4:
                                Console.Write("\nEnter player name to delete: ");
                                string playername = Console.ReadLine();
                                found = false;

                                foreach (APlayer player1 in club)
                                {
                                    if (player1.Name == playername)
                                    {
                                        club.DeletePlayer(player1);
                                        found = true;
                                        break;
                                    }
                                }

                                if (found)
                                {
                                    Console.WriteLine("\nPlayer deleted successfully.");
                                }
                                else
                                {
                                    Console.WriteLine("\nPlayer not found.");
                                }

                                break;
                            case 5: return;
                        }
                    }
                    catch (Exception ex) { Console.WriteLine("Wrong option!"); }
            }
            }
        }
    }


