using AdForm.ToDoList.Application.List.Response;
using MediatR;

namespace AdForm.ToDoList.Application.List.Query
{
    public class GetListQuery : IRequest<ListResponse>
    {
        public long Id { get; set; }
    }
}