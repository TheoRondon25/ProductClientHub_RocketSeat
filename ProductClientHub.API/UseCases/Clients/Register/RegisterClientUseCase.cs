using ProductClientHub.Communication.Responses;
using ProductClientHub.Communication.Requests;
using ProductClientHub.Exceptions.ExceptionBase;
using ProductClientHub.API.Infraestruture;
using ProductClientHub.API.Entities;
using ProductClientHub.API.UseCases.Clients.SharedValidator;

namespace ProductClientHub.API.UseCases.Clients.Register
{
    public class RegisterClientUseCase
    {
        public ResponseShortClientJson Execute(RequestClientJson request)
        {
            Validate(request);

            var dbContext = new ProductClientHubDbContext();

            var entity = new Client
            {
                // Id já é gerado quando chama um novo Client
                Name = request.Name,
                Email = request.Email                
            };

            dbContext.Clients.Add(entity);

            dbContext.SaveChanges();

            return new ResponseShortClientJson
            {
                Id = entity.Id,
                Name = entity.Name,
            };
        }     
        private void Validate(RequestClientJson request)
        {
            var validator = new RequestClientValidator();

            var result = validator.Validate(request);

            if (result.IsValid == false) // se tiver erro lança exceção
            {
                // vai percorrer cada elemento da lista, selecionar o erro e trazer em lista
                var errors = result.Errors.Select(failure => failure.ErrorMessage).ToList();

                throw new ErrorOnValidationException(errors);
            }
        }
    }
}
