using AdForm.ToDoList.Application.List.Command;
using AdForm.ToDoList.Application.List.Query;
using AdForm.ToDoList.Application.List.Response;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace AdForm.ToDoList.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ListController : ControllerBase
    {
        private readonly ILogger<ListController> _logger;
        private readonly IMediator _mediator;

        public ListController(
            ILogger<ListController> logger,
            IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<ListResponse>> GetAsync(GetListQuery query)
        {
            return await _mediator.Send(query);
        }

        [HttpPost]
        public async Task<ActionResult<ListResponse>> PostAsync(CreateListCommand command)
        {
            return await _mediator.Send(command);
        }

        [HttpPut]
        public async Task<ActionResult<ListResponse>> PutAsync(UpdateListCommand command)
        {
            await _mediator.Send(command);
            return NoContent();
        }

        [HttpDelete]
        public async Task<ActionResult<ListResponse>> DeleteAsync(DeleteListCommand command)
        {
            await _mediator.Send(command);
            return NoContent();
        }
    }
}