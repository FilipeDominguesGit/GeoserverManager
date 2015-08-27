using System;

namespace GeoserverManager.UseCases.Base.Interface.Exceptions
{
    public class UseCaseExecutionException : Exception
    {
        public UseCaseExecutionException()
        {
        }

        public UseCaseExecutionException(string message) : base(message)
        {
        }

        public UseCaseExecutionException(string mesaage, Exception innerException) : base(mesaage, innerException)
        {
        }
    }
}