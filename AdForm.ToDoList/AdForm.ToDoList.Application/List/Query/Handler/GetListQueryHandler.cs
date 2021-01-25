using AdForm.ToDoList.Application.List.Response;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace AdForm.ToDoList.Application.List.Query.Handler
{
    public class GetListQueryHandler : IRequestHandler<GetListQuery, ListResponse>
    {
        public Task<ListResponse> Handle(GetListQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new ListResponse());
        }
    }
}