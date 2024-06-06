using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TicketSystemBackEnd.Application.InputModel;
using TicketSystemBackEnd.Application.Service.Interfaces;
using TicketSystemBackEnd.Application.ViewModel;

namespace TicketSystemBackEnd.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class TicketController : ControllerBase
    {
        private readonly ITicketService _ticketService;
        public TicketController(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateTicketInputModel inputModel)
        {
            try
            {
                var ticket = await _ticketService.CreateTicketAsync(inputModel);

                return Ok(ticket);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var tickets = await _ticketService.GetAllTicketsAsync();

                return Ok(tickets);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                await _ticketService.DeleteTicketAsync(id);
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> Update(Guid id, [FromBody] UpdateTicketInputModel inputModel)
        {
            try
            {
                var ticket = await _ticketService.UpdateTicketAsync(id, inputModel);
                return Ok(ticket);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
