namespace Opcion1JoseLuisTeran.LMS.DataAccess.Repository.Entities;

public class Member : IEntityBase
{
    public Guid Id { get; }
    private string _firstName { get; set; }
    private string _lastName { get; set; }
    private string _phoneNumber { get; set; }
    private string _email { get; set; }
    private string _membershipNumber { get; set; }
    private MemberType _memberType { get; set; }

    public Member() {}

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

    public Member(string firstName, string lastName, string phoneNumber, string email, string membershipNumber, MemberType memberType)
    {
        Id = Guid.NewGuid();
        _firstName = firstName;
        _lastName = lastName;
        _phoneNumber = phoneNumber;
        _email = email;
        _membershipNumber = membershipNumber;
        _memberType = memberType;
    }

    public string FirstName 
    {
        get => _firstName;
        set => _firstName = value;
    }

    public string LastName 
    {
        get => _lastName;
        set => _lastName = value;
    }

    public string PhoneNumber 
    {
        get => _phoneNumber;
        set => _phoneNumber = value;
    }

    public string Email 
    {
        get => _email;
        set => _email = value;
    }

    public string MembershipNumber 
    {
        get => _membershipNumber;
        set => _membershipNumber = value;
    }

    public MemberType MemberType 
    {
        get => _memberType;
        set => _memberType = value;
    }

    public override string ToString()
    {
        return 
            // $"ID: {Id}\n" +
            $"First Name: {_firstName}\n" +
            $"Last Name: {_lastName}\n" +
            $"Phone Number: {_phoneNumber}\n" +
            $"Email: {_email}\n" +
            $"Membership Number: {_membershipNumber}\n" +
            $"Member Type: {_memberType}";
    }
}
