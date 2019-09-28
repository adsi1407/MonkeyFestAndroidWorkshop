using System.Collections.Generic;
using System.Linq;
using MonkeyFestWorkshop.DataAccess.Repositories;
using MonkeyFestWorkshop.Domain.Models.User;

namespace MonkeyFestWorkshop.DataAccess.Implementations.Real
{
    public class UserRepository: IUserRepository
    {
        private List<UserInfo> users;

        public UserRepository()
        {
            users = new List<UserInfo>();

            var user = new UserInfo();
            user.Id = "1111";
            user.Name = "David";
            users.Add(user);

            user = new UserInfo();
            user.Id = "2222";
            user.Name = "Stephany";
            users.Add(user);

            user = new UserInfo();
            user.Id = "3333";
            user.Name = "Esteban";
            users.Add(user);

        }

        public UserInfo GetUserInfo(string id)
        {
            return users.FirstOrDefault(x => x.Id.Equals(id));
        }
    }
}
