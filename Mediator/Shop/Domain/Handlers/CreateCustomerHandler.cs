using MediatR;
using Shop.Domain.Commands.Request;
using Shop.Domain.Commands.Response;

namespace Shop.Domain.Handlers
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerRequest, CreateCustomerResponse> //ICreateCustomerHandler
    {
        //public CreateCustomerResponse Handle(CreateCustomerRequest request)
        //{
        //    // Verifica se o cliente ja esta cadastrado
        //    // Valida os Dados
        //    // Insere o Cliente
        //    // Envia o email de boas vinda
        //    return new CreateCustomerResponse()
        //    {
        //        Id= Guid.NewGuid(),
        //        Name="Farley",
        //        Email="farley.t.i@hotmail.com",
        //        Date = DateTime.Now
        //    };
        //}
        public Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            // Verifica se o cliente ja esta cadastrado
            // Valida os Dados
            // Insere o Cliente
            // Envia o email de boas vinda
            var result = new CreateCustomerResponse()
            {
                Id = Guid.NewGuid(),
                Name = "Farley",
                Email = "farley.t.i@hotmail.com",
                Date = DateTime.Now
            };

            return Task.FromResult(result);
        }
    }
}
