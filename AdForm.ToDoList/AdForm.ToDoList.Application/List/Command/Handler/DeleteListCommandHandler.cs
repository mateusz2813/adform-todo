using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace AdForm.ToDoList.Application.List.Command.Handler
{
    public class DeleteListCommandHandler : IRequestHandler<DeleteListCommand>
    {
        public Task<Unit> Handle(DeleteListCommand request, CancellationToken cancellationToken)
        {
            //TODO

            return Task.FromResult(Unit.Value);
        }
    }
}