using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoserverManager.UseCases.Base.Interface.Exceptions
{
    public class UseCaseExecutionException : Exception
    {
        public UseCaseExecutionException() : base() { }

        public UseCaseExecutionException(string message) : base(message) { }

        public UseCaseExecutionException(string mesaage, Exception innerException) : base(mesaage, innerException) { }
    }
}
