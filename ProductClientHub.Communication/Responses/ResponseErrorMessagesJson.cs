using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductClientHub.Communication.Responses
{
    public class ResponseErrorMessagesJson
    {
        public List<string> Errors { get; private set; }

        public ResponseErrorMessagesJson(string message)
        {
            Errors = new List<string> { message }; // ou Errors = [message]
        }
        public ResponseErrorMessagesJson(List<string> messages)
        {
            Errors = messages;
        }
    }
}
