using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace AdForm.ToDoList.Application.List.Command.Handler
{
    public class UpdateListCommandHandler : IRequestHandler<UpdateListCommand>
    {
        public Task<Unit> Handle(UpdateListCommand request, CancellationToken cancellationToken)
        {
            //TODO

            return Task.FromResult(Unit.Value);
        }
    }
}