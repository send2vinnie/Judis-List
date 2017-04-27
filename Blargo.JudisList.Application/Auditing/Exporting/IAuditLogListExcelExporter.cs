using System.Collections.Generic;
using Blargo.JudisList.Auditing.Dto;
using Blargo.JudisList.Dto;

namespace Blargo.JudisList.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);
    }
}
