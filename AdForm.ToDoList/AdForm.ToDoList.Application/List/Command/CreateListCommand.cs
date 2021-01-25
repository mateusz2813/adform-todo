using AdForm.ToDoList.Application.List.Response;
using MediatR;

namespace AdForm.ToDoList.Application.List.Command
{
    public class CreateListCommand : IRequest<ListResponse>
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }
}