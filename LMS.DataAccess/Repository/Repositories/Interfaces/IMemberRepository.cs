using Opcion1JoseLuisTeran.LMS.DataAccess.Repository.Entities;

namespace Opcion1JoseLuisTeran.LMS.DataAccess.Repository.Repositories.Interfaces;

public interface IMemberRepository : IBaseRepository<Member>
{
    Task<IList<Member>> GetMembers(string membershipNumber);
}
