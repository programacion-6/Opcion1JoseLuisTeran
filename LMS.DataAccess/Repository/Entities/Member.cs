namespace Opcion1JoseLuisTeran.LMS.DataAccess.Repository.Entities;

public class Member : IEntityBase
{
    public Guid Id { get; set; }
    public string _firstName { get; set; }
    public string _lastName { get; set; }
    public string _phoneNumber { get; set; }
    public string _email { get; set; }
    public string _membershipNumber { get; set; }
    public MemberType _memberType { get; set; }

    public Member(Guid id, string firstName, string lastName, string phoneNumber, string email, string membershipNumber, MemberType memberType)
    {
        Id = id;
        _firstName = firstName;
        _lastName = lastName;
        _phoneNumber = phoneNumber;
        _email = email;
        _membershipNumber = membershipNumber;
        _memberType = memberType;
    }

    public override string ToString()
    {
        return 
            $"First Name: {_firstName}\n" +
            $"Last Name: {_lastName}\n" +
            $"Phone Number: {_phoneNumber}\n" +
            $"Email: {_email}\n" +
            $"Membership Number: {_membershipNumber}\n" +
            $"Member Type: {_memberType}";
    }
}
