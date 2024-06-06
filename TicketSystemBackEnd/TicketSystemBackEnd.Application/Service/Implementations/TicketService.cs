using System.IO;
using System.Runtime.InteropServices;
using TicketSystemBackEnd.Application.InputModel;
using TicketSystemBackEnd.Application.Service.Interfaces;
using TicketSystemBackEnd.Application.ViewModel;
using TicketSystemBackEnd.Core.Entities;
using TicketSystemBackEnd.Core.Exceptions;
using TicketSystemBackEnd.Core.Repositories;

namespace TicketSystemBackEnd.Application.Service.Implementations
{
    public class TicketService : ITicketService
    {
        private readonly ITicketRepository _ticketRepository;
        public TicketService(ITicketRepository ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }
        public async Task<TicketViewModel> CreateTicketAsync(CreateTicketInputModel inputModel)
        {
            var ticket = new Ticket(inputModel.AIT, inputModel.FineDate, inputModel.FineCode, inputModel.Plate);

            if (await CheckTicketByAITAsync(inputModel.AIT) == false)
            {
                if(await CheckTicketByPartAITAsync(inputModel.AIT))
                {
                    if(await CheckTicketByDateAsync(inputModel.FineDate))
                    {
                        if(await CheckTicketByCodeAsync(inputModel.FineCode))
                        {
                            if(await CheckTicketByPlateAsync(inputModel.Plate))
                            {
                                throw new PendingAITException();
                            }
                            else
                            {
                                await _ticketRepository.AddAsync(ticket);
                                return await GetTicketByAITAsync(ticket.AIT);
                            }
                        }
                        else
                        {
                            await _ticketRepository.AddAsync(ticket);
                            return await GetTicketByAITAsync(ticket.AIT);
                        }
                    }
                    else
                    {
                        await _ticketRepository.AddAsync(ticket);
                        return await GetTicketByAITAsync(ticket.AIT);
                    }
                }
                else
                {
                    await _ticketRepository.AddAsync(ticket);
                    return await GetTicketByAITAsync(ticket.AIT);
                }
            }
            else
            {
                return await GetTicketByAITAsync(ticket.AIT);
            }

        }

        public async Task DeleteTicketAsync(Guid id)
        {
            var ticket = await _ticketRepository.GetByIdAsync(id);
            if (ticket == null)
                throw new TicketNonExistException();

            await _ticketRepository.DeleteAsync(ticket);
        }

        public async Task<bool> CheckTicketByAITAsync(string aIT)
        {
            var ticket = await _ticketRepository.GetByAITAsync(aIT);  
            return ticket != null;
        }

        public async Task<bool> CheckTicketByCodeAsync(string code)
        {
            var ticket = await _ticketRepository.GetByCodeAsync(code);
            return ticket != null;
        }

        public async Task<bool> CheckTicketByDateAsync(DateTime date)
        {
            var ticket = await _ticketRepository.GetByDateAsync(date);
            return ticket != null;

        }

        public async Task<bool> CheckTicketByPartAITAsync(string aIT)
        {
            var ticket = await _ticketRepository.GetByPartAITAsync(aIT);
            return ticket != null;
        }

        public async Task<bool> CheckTicketByPlateAsync(string plate)
        {
            var ticket = await _ticketRepository.GetByPlateAsync(plate);
            return ticket != null;

        }

        public async Task<TicketViewModel> GetTicketByAITAsync(string aIT)
        {
            var ticket = await _ticketRepository.GetByAITAsync(aIT);

            var ticketViewModel = new TicketViewModel(ticket.AIT, ticket.FineDate, ticket.FineCode, ticket.Plate);

            return ticketViewModel;
        }

        public async Task<TicketViewModel> UpdateTicketAsync(Guid id, UpdateTicketInputModel inputModel)
        {
            var ticket = await _ticketRepository.GetByIdAsync(id);

            if (ticket == null)
                throw new TicketNonExistException();

            ticket.Update(inputModel.AIT, inputModel.FineDate, inputModel.FineCode, inputModel.Plate);

            await _ticketRepository.SaveChangesAsync(ticket);

            var ticketViewModel = new TicketViewModel(ticket.AIT, ticket.FineDate, ticket.FineCode, ticket.Plate);

            return ticketViewModel;
        }

        public async Task<List<TicketViewModel>> GetAllTicketsAsync()
        {
            var tickets = await _ticketRepository.GetAllAsync();

            var ticketsViewModel = tickets
                .Select(t => new TicketViewModel(t.AIT, t.FineDate, t.FineCode, t.Plate))
                .ToList();

            return ticketsViewModel;
        }
    }
}
