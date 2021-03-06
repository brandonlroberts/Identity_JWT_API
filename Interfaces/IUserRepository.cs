using System.Collections.Generic;
using System.Threading.Tasks;
using Identity_JWT_API.DTOs;
using Identity_JWT_API.Extensions.Entities;
using Identity_JWT_API.Helpers;

namespace Identity_JWT_API.Interfaces
{
    public interface IUserRepository
    {
        void Update(AppUser user);
        Task<IEnumerable<AppUser>> GetUsersAsync();
        Task<AppUser> GetUserByIdAsync(int id);
        Task<AppUser> GetUserByUsernameAsync(string username);
        Task<PagedList<MemberDto>> GetMembersAsync(UserParams userParams);
        Task<MemberDto> GetMemberAsync(string username);
    }
}