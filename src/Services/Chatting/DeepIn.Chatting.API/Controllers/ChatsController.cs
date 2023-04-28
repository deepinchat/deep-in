using DeepIn.Chatting.Application.Commands.Chats;
using DeepIn.Chatting.Application.Dtos;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DeepIn.Chatting.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ChatsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<ChatDTO>> CreateChat([FromBody] CreateChatCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpPost("dialogue")]
        public async Task<ActionResult<ChatDTO>> CreateDialogue([FromBody] CreateDialogueCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
