using appDist.micro.History.Dto;

namespace appDist.micro.History.Services.Interfaces
{
    public interface IHistoryService
    {
        Task<List<CategoryHistoryDto>> ListAsync();
    }
}
