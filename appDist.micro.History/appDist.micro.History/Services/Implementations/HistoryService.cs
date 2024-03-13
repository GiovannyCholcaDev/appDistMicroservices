using appDist.micro.History.Dto;
using appDist.micro.History.Models;
using appDist.micro.History.Persistences;
using appDist.micro.History.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace appDist.micro.History.Services.Implementations
{
    public class HistoryService : IHistoryService
    {

        private readonly ContextDatabase context;

        public HistoryService(ContextDatabase context) => this.context = context;


        public async Task<List<CategoryHistoryDto>> ListAsync()
        {

            List<HistoryModel> historLista = await context.Histories.ToListAsync();

            var lista  = historLista.Select(h => new CategoryHistoryDto { 
                Name = h.Name,
                Description = h.Description
            }).ToList();

            return lista;
            
        }
    }
}
