﻿using MediatR;

namespace CQRS.Query
{
    public interface IQueryHandler<in TRequest, TResponse> : IRequestHandler<TRequest, TResponse> where TRequest : IQuery<TResponse>
    {
    }
}
