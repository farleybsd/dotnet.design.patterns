﻿using MediatR;
using Shop.Domain.Commands.Response;

namespace Shop.Domain.Commands.Request
{
    public class CreateCustomerRequest : IRequest<CreateCustomerResponse>
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
