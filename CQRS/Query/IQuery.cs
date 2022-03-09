using MediatR;

namespace CQRS.Query
{
    public interface IQuery<out TResponse> : IRequest<TResponse>
    {
    }
}
