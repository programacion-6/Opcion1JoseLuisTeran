using Opcion1JoseLuisTeran.LMS.DataAccess.Repository.Entities;
using Opcion1JoseLuisTeran.LMS.DataAccess.Repository.Repositories.Concrets;
using Opcion1JoseLuisTeran.LMS.DataAccess.Repository.Repositories.Interfaces;

namespace Opcion1JoseLuisTeran.LMS.DataAccess.UI;

public class MemberComponents
{
    public static IMemberRepository _memberRepository = new MemberRepository();
    private static MemberRepository memberRepository = new MemberRepository();

    public static void AddMember()
    {
        Console.Clear();
        Console.WriteLine("Enter Member Details");
        Console.Write("First Name: ");
        string firstName = Console.ReadLine();
        Console.Write("Last Name: ");
        string lastName = Console.ReadLine();
        Console.Write("Phone Number: ");
        string phoneNumber = Console.ReadLine();
        Console.Write("Email: ");
        string email = Console.ReadLine();
        Console.Write("Membership Number: ");
        string membershipNumber = Console.ReadLine();
        Console.Write("Member Type (ADMINISTRATOR/STAFF/TEACHER/STUDENT/PATRON): ");
        MemberType memberType = (MemberType)Enum.Parse(typeof(MemberType), Console.ReadLine().ToUpper());

        var member = new Member(firstName, lastName, phoneNumber, email, membershipNumber, memberType);
        _memberRepository.Create(member);
        Console.WriteLine("Member added successfully. Press any key to continue.");
        Console.ReadKey();
    }

    public static void ViewAllMembers()
    {
        Console.Clear();
        Console.WriteLine("All Members:");
        foreach (var member in _memberRepository.GetAll())
        {
            Console.WriteLine(member);
            Console.WriteLine();
        }
        Console.WriteLine("Press any key to continue.");
        Console.ReadKey();
    }

    public static void SearchMembers()
    {
        Console.Clear();
        Console.WriteLine("Search Members");
        Console.WriteLine("1. By First Name");
        Console.WriteLine("2. By Last Name");
        Console.WriteLine("3. By Phone Number");
        Console.WriteLine("4. By Email");
        Console.WriteLine("5. By Membership Number");
        Console.WriteLine("6. By Member Type");
        Console.Write("Select an option: ");
        string option = Console.ReadLine();

        IEnumerable<Member> members = null;
        switch (option)
        {
            case "1":
                Console.Write("Enter First Name: ");
                string firstName = Console.ReadLine();
                members = memberRepository.GetByFirstName(firstName);
                break;
            case "2":
                Console.Write("Enter Last Name: ");
                string lastName = Console.ReadLine();
                members = memberRepository.GetByLastName(lastName);
                break;
            case "3":
                Console.Write("Enter Phone Number: ");
                string phoneNumber = Console.ReadLine();
                members = memberRepository.GetByPhoneNumber(phoneNumber);
                break;
            case "4":
                Console.Write("Enter Email: ");
                string email = Console.ReadLine();
                members = memberRepository.GetByEmail(email);
                break;
            case "5":
                Console.Write("Enter Membership Number: ");
                string membershipNumber = Console.ReadLine();
                var member = _memberRepository.GetByMembershipNumber(membershipNumber);
                Console.WriteLine(member);
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                return;
            case "6":
                Console.Write("Enter Member Type (ADMINISTRATOR/STAFF/TEACHER/STUDENT/PATRON): ");
                MemberType memberType = (MemberType)Enum.Parse(typeof(MemberType), Console.ReadLine().ToUpper());
                members = memberRepository.GetByMemberType(memberType);
                break;
            default:
                Console.WriteLine("Invalid option, returning to Admin Menu.");
                return;
        }

        Console.Clear();
        Console.WriteLine("Search Results:");
        foreach (var member in members)
        {
            Console.WriteLine(member);
            Console.WriteLine();
        }
        Console.WriteLine("Press any key to continue.");
        Console.ReadKey();
    }
}
