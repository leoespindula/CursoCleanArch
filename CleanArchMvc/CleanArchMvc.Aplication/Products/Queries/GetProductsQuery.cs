﻿using CleanArchMvc.Domain.Entities;
using MediatR;

namespace CleanArchMvc.Aplication.Products.Queries
{
    public class GetProductsQuery : IRequest<IEnumerable<Product>>
    {
    }
}