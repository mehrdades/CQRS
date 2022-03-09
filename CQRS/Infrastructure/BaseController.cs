using CQRS.Command;
using CQRS.Query;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CQRS.Infrastructure
{
    public abstract class BaseController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BaseController(IMediator mediator)
        {
            _mediator = mediator;
        }

        protected async Task<TResponse> Fetch<TResponse>(IQuery<TResponse> query) =>
            await _mediator.Send<TResponse>(query);

        protected async Task Command(ICommand command) =>
            await _mediator.Send(command);
    }
}
