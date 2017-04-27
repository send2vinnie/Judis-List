using System.Collections.ObjectModel;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace Blargo.JudisList.ClassTypes.Dto
{
    public class ClassTypeListDto : FullAuditedEntityDto
    {
        public string ClassTypeName { get; set; }

    }
}
