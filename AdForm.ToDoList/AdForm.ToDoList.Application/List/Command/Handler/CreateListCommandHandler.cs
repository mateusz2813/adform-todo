using AdForm.ToDoList.Application.List.Response;
using AdForm.ToDoList.Domain;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace AdForm.ToDoList.Application.List.Command.Handler
{
    public class CreateListCommandHandler : IRequestHandler<CreateListCommand, ListResponse>
    {
        private readonly ToDoRepository _repository;

        public CreateListCommandHandler(ToDoRepository repository)
        {
            _repository = repository;
        }

        public async Task<ListResponse> Handle(CreateListCommand request, CancellationToken cancellationToken)
        {
            var entity = new Domain.Lists.List
            {
                Name = request.Name,
                Description = request.Description,
                CreationDate = DateTime.Now,
                LastUpdateDate = DateTime.Now
            };

            var result = await _repository.AddAsync(entity);
            await _repository.SaveChangesAsync();

            var response = new ListResponse
            {
                Id = result.Entity.Id
            };

            return response;
        }
    }
}