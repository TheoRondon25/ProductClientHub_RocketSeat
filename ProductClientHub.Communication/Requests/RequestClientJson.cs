namespace ProductClientHub.Communication.Requests
{
    public class RequestClientJson
    {
        public string Name { get; set; } = string.Empty;
        // se nao for passado nada, a string inicia como vazia e nao nula
        public string Email { get; set; } = string.Empty;
    }
}
