using System;
using MonkeyFestWorkshop.DataAccess.Repositories;
using MonkeyFestWorkshop.Domain.Models.User;

namespace MonkeyFestWorkshop.Core.DomainServices
{
    public class UserServiceDomain
    {
        private readonly IUserRepository userRepository;

        public UserServiceDomain(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public UserInfo GetUserInfo(string id)
        {
            return userRepository.GetUserInfo(id);
        }
    }
}
