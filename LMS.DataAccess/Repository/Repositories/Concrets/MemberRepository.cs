using Opcion1JoseLuisTeran.LMS.DataAccess.Repository.Entities;
using Opcion1JoseLuisTeran.LMS.DataAccess.Repository.Repositories.Interfaces;

namespace Opcion1JoseLuisTeran.LMS.DataAccess.Repository.Repositories.Concrets;

public class MemberRepository : BaseRepository<Member>, IMemberRepository
{
    public Member GetByMembershipNumber(string membershipNumber)
    {
        return GetByParameter(member => member.MembershipNumber == membershipNumber).FirstOrDefault();
    }

    public IEnumerable<Member> GetByFirstName(string firstName)
    {
        return GetByParameter(member => member.FirstName == firstName);
    }

    public IEnumerable<Member> GetByLastName(string lastName)
    {
        return GetByParameter(member => member.LastName == lastName);
    }

    public IEnumerable<Member> GetByPhoneNumber(string phoneNumber)
    {
        return GetByParameter(member => member.PhoneNumber == phoneNumber);
    }

    public IEnumerable<Member> GetByEmail(string email)
    {
        return GetByParameter(member => member.Email == email);
    }

    public IEnumerable<Member> GetByMemberType(MemberType memberType)
    {
        return GetByParameter(member => member.MemberType == memberType);
    }
}
