using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductClientHub.Communication.Responses
{
    public class ResponseAllClientsJson
    {
        // estou inicializando a lista sempre que é chamado com = []
        public List<ResponseShortClientJson> Clients { get; set; } = []; 
    }
}
