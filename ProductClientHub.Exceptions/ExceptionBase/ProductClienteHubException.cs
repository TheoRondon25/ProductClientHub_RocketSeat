using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ProductClientHub.Exceptions.ExceptionBase
{
    public abstract class ProductClienteHubException : SystemException
    {
        public ProductClienteHubException(string errorMessage) : base(errorMessage) 
        {            
        }

        public abstract List<string> GetErrors();
        public abstract HttpStatusCode GetHttpStatusCode();
    }
}
