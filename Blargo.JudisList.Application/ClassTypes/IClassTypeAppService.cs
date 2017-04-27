﻿using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Blargo.JudisList.ClassTypes.Dto;

namespace Blargo.JudisList.ClassTypes
{
    public interface IClassTypesAppService : IApplicationService
    {
        ListResultDto<ClassTypeListDto> GetPeople(GetClassTypesInput input);

        Task CreateClassType(CreateClassTypeInput input);

        Task DeleteClassType(EntityDto input);
    }
}