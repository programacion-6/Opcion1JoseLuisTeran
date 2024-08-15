using Opcion1JoseLuisTeran.LMS.DataAccess.Repository.Entities;

namespace Opcion1JoseLuisTeran.LMS.DataAccess.Repository.Repositories.Interfaces;

public interface IMemberRepository : IBaseRepository<Member>
{
    Member GetByMembershipNumber(string membershipNumber);
}
