using System;
namespace MonkeyFestWorkshop.Core.Contracts.Platform
{
    public interface INetworkStrategy
    {
        bool IsConnected();
    }
}
