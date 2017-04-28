using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Blargo.JudisList.ClassTypes.Dto;

namespace Blargo.JudisList.Web.Areas.Mpa.Models.ClassTypes
{
        [AutoMapFrom(typeof(ListResultDto<ClassTypeListDto>))]
        public class IndexViewModel : ListResultDto<ClassTypeListDto>
        {
            public string Filter { get; set; }

            public IndexViewModel(ListResultDto<ClassTypeListDto> output, string filter = null)
            {
                output.MapTo(this);
                Filter = filter;
            }
        }
}