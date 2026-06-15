using TaxiManager9000.Domain.BaseEntity;
using TaxiManager9000.Domain.Enums;
using TaxiManager9000.Domain.Models;
using TaxiManager9000.Helpers;
using TaxiManager9000.Services.Enums;
using TaxiManager9000.Services.Interfaces;

namespace TaxiManager9000.Services.Services
{
    public class UIService : IUIService
    {
        private List<MenuChoice> _menuItems;
        public List<MenuChoice> MenuItems 
        { 
            get => _menuItems; 
            set //set samo ni zacuvuva ne ni vrakja
                {
                if (_menuItems != null)
                {
                    _menuItems.Clear();
                }
                _menuItems = value;//ova value toa sto kje mu dojde menu items 
                //vo samiot servise se koristi Menuitems spored Role sto tocno ima
                //pristap ovoj korisnik pri setiranje prie sekoe novo najavuvanje
                //na userot ako imame polnenje imame set ako imame set kje gfunckionira
                //imame vrenost i se prepokriva  DA SE OSIGURAME SO if ako imame vrednost
                //izbrisi ja vrenosta i dodani mu nova vrednost _menuItems=value
                //za da sme sigurni deka bob nema da gi gleda podatocite na adminot
            }
        }


        public int ChooseMenu<T>(List<T> items) // ["Login", "Exit"]
        {
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {items[i]}");
            }
            int choice = ValidationHelper.ValidateNumberInput(Console.ReadLine(), items.Count);
            return choice;
        }

        public int ChoseEntitiesMenu<T>(List<T> entities) where T : BaseEntity
        {
            while (true)
            {
                Console.WriteLine("Enter a number to choose one of the following: ");
                for(int i=0; i <entities.Count; i++)
                {
                    Console.WriteLine($"{i+1}) {entities[i].GetInfo()}");
                }
                int choise = ValidationHelper.ValidateNumberInput(Console.ReadLine(),entities.Count);
                if (choise == -1)
                {
                    ConsoleHelper.PrintError("Incalid choice! Try agin..");
                    Console.Clear();
                    continue;
                }
                return choise;
            }
        }

        public User LogInMenu()
        {
            Console.Clear();
            ConsoleHelper.PrintInColor("Enter your credentials:", ConsoleColor.Cyan);
            string? username = ConsoleHelper.GetInput("Username: ");
            string? password = ConsoleHelper.GetInput("Password: ");
            if (!ValidationHelper.ValidateStringInput(username) || !ValidationHelper.ValidateStringInput(password))
            {
                throw new Exception("Please enter valid inputs!");
            }

            return new User
            {
                Username = username,
                Password = password
            };
        }

        public int MainMenu(Role role)
        {
            while (true)
            {
                Console.Clear();
                ConsoleHelper.PrintTitle($"========== [{role.ToString()}] MENU ==========");
                MenuItems = GetMenuOptionsForRole(role);
                int userChoice = ChooseMenu(MenuItems);
                if(userChoice == -1) 
                {
                    ConsoleHelper.PrintError("Invalid choice! Try again...");
                    continue;
                }
                return userChoice;
            }
        }

        private List<MenuChoice> GetMenuOptionsForRole(Role role) 
        {
            List<MenuChoice> menuItems = new List<MenuChoice>();//lista so ponenje na koj role 
            switch (role) 
            {
                case Role.Administrator:
                    menuItems = new List<MenuChoice>()
                    {
                        MenuChoice.AddNewUser,
                        MenuChoice.RemoveExistingUser,
                        MenuChoice.ChangePassword,
                        MenuChoice.Exit
                    };
                    break;

                case Role.Manager:
                    menuItems = new List<MenuChoice>()
                    {
                        MenuChoice.ListAllDrivers,
                        MenuChoice.TaxiLicenseStatus,
                        MenuChoice.DriverManager,
                        MenuChoice.ChangePassword,
                        MenuChoice.Exit
                    };
                    break;

                case Role.Maintenance:
                    menuItems = new List<MenuChoice>()
                    {
                        MenuChoice.ListAllCars,
                        MenuChoice.LicensePlateStatus,
                        MenuChoice.ChangePassword,
                        MenuChoice.Exit
                    };
                    break;

                default:
                    menuItems = new List<MenuChoice>();
                    break;
            }
            return menuItems;
        }
    }
}
