using AdForm.ToDoList.Application.List.Response;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace AdForm.ToDoList.Application.List.Command.Handler
{
    public class CreateListCommandHandler : IRequestHandler<CreateListCommand, ListResponse>
    {
        public Task<ListResponse> Handle(CreateListCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new ListResponse());
        }
    }
}