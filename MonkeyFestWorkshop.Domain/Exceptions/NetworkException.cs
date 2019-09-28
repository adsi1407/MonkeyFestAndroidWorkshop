using System;
namespace MonkeyFestWorkshop.Domain.Exceptions
{
    public class NetworkException : Exception
    {
        private const string message = "Error de conexión";

        public NetworkException() : base(message)
        {
        }
    }
}
