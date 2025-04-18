using ParkingSeleniumProject.Core.Dtos;
using System.Security.Claims;

namespace ParkingSeleniumProject.Core.Interface
{
    public interface ILogService
    {
        Task SaveNewLog(string UserName, string Description);
        Task<IEnumerable<GetLogDto>> GetLogsAsync();
        Task<IEnumerable<GetLogDto>> GetMyLogsAsync(ClaimsPrincipal User);
    }
}
