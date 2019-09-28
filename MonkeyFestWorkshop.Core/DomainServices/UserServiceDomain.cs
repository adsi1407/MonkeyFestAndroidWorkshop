using System;
using MonkeyFestWorkshop.Core.Contracts.Platform;
using MonkeyFestWorkshop.DataAccess.Repositories;
using MonkeyFestWorkshop.Domain.Exceptions;
using MonkeyFestWorkshop.Domain.Models.User;

namespace MonkeyFestWorkshop.Core.DomainServices
{
    public class UserServiceDomain
    {
        private readonly IUserRepository userRepository;
        private readonly INetworkStrategy networkStrategy;

        public UserServiceDomain(IUserRepository userRepository, INetworkStrategy networkStrategy)
        {
            this.userRepository = userRepository;
            this.networkStrategy = networkStrategy;
        }

        public UserInfo GetUserInfo(string id)
        {
            if (networkStrategy.IsConnected())
            {
                return userRepository.GetUserInfo(id);
            }

            throw new NetworkException();
        }
    }
}
