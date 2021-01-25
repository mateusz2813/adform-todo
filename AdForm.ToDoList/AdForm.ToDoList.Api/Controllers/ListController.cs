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
        public async Task<ActionResult<ListResponse>> GetAsync([FromQuery] GetListQuery query)
        {
            return Ok(await _mediator.Send(query));
        }

        [HttpPost]
        public async Task<ActionResult<ListResponse>> PostAsync([FromBody] CreateListCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpPut]
        public async Task<ActionResult<ListResponse>> PutAsync([FromBody] UpdateListCommand command)
        {
            await _mediator.Send(command);
            return NoContent();
        }

        [HttpDelete]
        public async Task<ActionResult<ListResponse>> DeleteAsync([FromBody] DeleteListCommand command)
        {
            await _mediator.Send(command);
            return NoContent();
        }
    }
}