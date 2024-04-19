using RoomManageBusinessServices;
using ROOMMSDL;
using ROOMMSMODEL;
using ROOMMSMODEL;
using System.Security.Cryptography.X509Certificates;

namespace RoomMSUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO ROOM MANAGEMENT SYSTEM");
            Console.WriteLine("\n Log In");
            Console.WriteLine("\n Enter username");
            string username = Console.ReadLine();
            Console.WriteLine("\n Enter Password");
            string password = Console.ReadLine();

            UserService userService = new UserService();
            bool result = userService.VerifyUser(username, password);

            if(result)
            {
                Console.WriteLine("Welcome");
                ShowMenu();
            }
            else
            {
                Console.WriteLine("Error");
            }

        }

        static void ShowMenu()
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\n1. Status of the Rooms");
                Console.WriteLine("2. Show all Informations");
                Console.WriteLine("3. Exit");
                Console.WriteLine("\nSelect an Option");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                       
                        Console.WriteLine("Here are the status of all of the Rooms ");
                        DisplayStatus();
                        break;

                    case "2":
                        Console.WriteLine("Here are the Informations of all of the Rooms: ");
                        DisplayRoom();
                        break;

                    case "3":
                        exit = true;
                        break;
                }

            }
                
        }



        static void DisplayRoom()
        {
            RoomManageDataServices dataServices = new RoomManageDataServices();
            var rooms = dataServices.rooms;

            foreach(var room in rooms)
            {
                Console.WriteLine("\n");
                Console.WriteLine($"Room Number: {room.roomNo ?? "N/A"}");
                Console.WriteLine($"Name: {room.name ?? "N/A"}");
                Console.WriteLine($"Phone Number: {room.phoneNum ?? "N/A"}");
                Console.WriteLine($"Number of People Renting: {room.numRent ?? "N/A"}");
                Console.WriteLine($"Number of Pets: {room.pets ?? "N/A"}");
                Console.WriteLine($"With A/C: {room.ac ?? "N/A"}");
            }
        }

        static void DisplayStatus()
        {
            RoomManageDataServices dataServices = new RoomManageDataServices();

            var rooms = dataServices.rooms;
            Console.WriteLine("Room Status:");
            foreach (var kwarto in rooms)
            {
                Console.WriteLine($"\nRoom Number: {kwarto.roomNo}: {kwarto.status}");
            }
        }
    }
}
