namespace Opcion1JoseLuisTeran.LMS.DataAccess.UI;

public class MenuComponents
{
    public static void AdminMenu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Admin Menu");
            Console.WriteLine("1. Add a Book");
            Console.WriteLine("2. View All Books");
            Console.WriteLine("3. Search Books");
            Console.WriteLine("4. Add a Member");
            Console.WriteLine("5. View All Members");
            Console.WriteLine("6. Search Members");
            Console.WriteLine("7. Log Out");
            Console.Write("Select an option: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    BookComponents.AddBook();
                    break;
                case "2":
                    BookComponents.ViewAllBooks();
                    break;
                case "3":
                    BookComponents.SearchBooks();
                    break;
                case "4":
                    MemberComponents.AddMember();
                    break;
                case "5":
                    MemberComponents.ViewAllMembers();
                    break;
                case "6":
                    MemberComponents.SearchMembers();
                    break;
                case "7":
                    return;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }

    public static void UserMenu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("User Menu");
            Console.WriteLine("1. View All Books");
            Console.WriteLine("2. Search Books");
            Console.WriteLine("3. Borrow a Book");
            Console.WriteLine("4. Return a Book");
            Console.WriteLine("5. Check Book Availability");
            Console.WriteLine("6. Log Out");
            Console.Write("Select an option: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    BookComponents.ViewAllBooks();
                    break;
                case "2":
                    BookComponents.SearchBooks();
                    break;
                case "3":
                    BorrowComponents.BorrowBook();
                    break;
                case "4":
                    BorrowComponents.ReturnBook();
                    break;
                case "5":
                    BorrowComponents.CheckBookAvailability();
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }
}
