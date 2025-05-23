using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ProductClientHub.Exceptions.ExceptionBase
{
    public class ErrorOnValidationException : ProductClienteHubException
    {
        private readonly List<string> _errors;

        public ErrorOnValidationException(List<string> errorMessage) : base(string.Empty)
        {
            _errors = errorMessage;
        }

        public override List<string> GetErrors() => _errors;
        public override HttpStatusCode GetHttpStatusCode() => HttpStatusCode.BadRequest;
    }
}
