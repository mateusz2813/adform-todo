using AdForm.ToDoList.Application.List.Response;
using MediatR;

namespace AdForm.ToDoList.Application.List.Command
{
    public class CreateListCommand : IRequest<ListResponse>
    {
    }
}