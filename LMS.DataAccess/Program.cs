using Opcion1JoseLuisTeran.LMS.DataAccess.Repository.Entities;
using Opcion1JoseLuisTeran.LMS.DataAccess.Repository.Repositories.Concrets;
using Opcion1JoseLuisTeran.LMS.DataAccess.Repository.Repositories.Interfaces;
using Opcion1JoseLuisTeran.LMS.DataAccess.UI;

public class Program
{
    private static Member _loggedInMember;

    public static void Main(string[] args)
    {
        MainMenu();
    }

    public static void MainMenu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Library Management System");
            Console.WriteLine("1. Admin Login");
            Console.WriteLine("2. User Login");
            Console.WriteLine("3. Exit");
            Console.Write("Select an option: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    AdminLogin();
                    break;
                case "2":
                    UserLogin();
                    break;
                case "3":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }

    public static void AdminLogin()
    {
        Console.Clear();
        Console.WriteLine("Enter Admin Name:");
        string adminName = Console.ReadLine();

        if (adminName.Equals("admin", StringComparison.OrdinalIgnoreCase))
        {
            MenuComponents.AdminMenu();
        }
        else
        {
            Console.WriteLine("Invalid Admin Name. Press any key to return to the main menu.");
            Console.ReadKey();
        }
    }

    public static void UserLogin()
    {
        Console.Clear();
        Console.WriteLine("Enter Membership Number:");
        string membershipNumber = Console.ReadLine();

        _loggedInMember = MemberComponents._memberRepository.GetByMembershipNumber(membershipNumber);
        if (_loggedInMember != null)
        {
            MenuComponents.UserMenu();
        }
        else
        {
            Console.WriteLine("Invalid Membership Number. Press any key to return to the main menu.");
            Console.ReadKey();
        }
    }
}
