using MonkeyFestWorkshop.DataAccess.Repositories;
using MonkeyFestWorkshop.Domain.Models.User;

namespace MonkeyFestWorkshop.DataAccess.Implementations.Mock
{
    public class UserRepositoryMock : IUserRepository
    {
        public UserInfo GetUserInfo(string id)
        {
            return new UserInfo
            {
                Id = "1111111",
                Name = "Pepito Mock"
            };
        }
    }
}
