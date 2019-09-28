using System;
using Android.App;
using Android.Content;
using Android.Net;
using MonkeyFestWorkshop.Core.Contracts.Platform;

namespace MonkeyFestWorkshop.Droid.DependencyInjection.Strategies
{
    public class NetworkStrategy : INetworkStrategy
    {
        private readonly Context context;

        public NetworkStrategy()
        {
            context = Application.Context;
        }

        public bool IsConnected()
        {
            ConnectivityManager connectivityManager = (ConnectivityManager)context.GetSystemService(Context.ConnectivityService);
            NetworkInfo activeConnection = connectivityManager.ActiveNetworkInfo;
            return (activeConnection != null) && activeConnection.IsConnected;
        }
    }
}
