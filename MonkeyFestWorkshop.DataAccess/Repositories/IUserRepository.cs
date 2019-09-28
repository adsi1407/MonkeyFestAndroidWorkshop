using MonkeyFestWorkshop.Domain.Models.User;

namespace MonkeyFestWorkshop.DataAccess.Repositories
{
    public interface IUserRepository
    {
        UserInfo GetUserInfo(string id);
    }
}
