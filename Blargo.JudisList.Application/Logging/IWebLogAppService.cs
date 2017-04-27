using Abp.Application.Services;
using Blargo.JudisList.Dto;
using Blargo.JudisList.Logging.Dto;

namespace Blargo.JudisList.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
