using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.AutoMapper;
using Abp.Collections.Extensions;
using Abp.Domain.Repositories;
using Abp.Extensions;
using Blargo.JudisList.Authorization;
using Blargo.JudisList.ClassTypes.Dto;

namespace Blargo.JudisList.ClassTypes
{
    [AbpAuthorize(AppPermissions.Pages_Tenant_ClassTypes)]
    public class ClassTypeAppService : JudisListAppServiceBase, IClassTypeAppService
    {

        private readonly IRepository<ClassType> _classTypeRepository;

        public ClassTypeAppService(
            IRepository<ClassType> ClassTypeRepository)
        {
            _classTypeRepository = ClassTypeRepository;
        }

        public ListResultDto<ClassTypeListDto> GetClassTypes(GetClassTypesInput input)
        {
            var ClassTypes = _classTypeRepository
                .GetAll()
                .WhereIf(
                    !input.Filter.IsNullOrEmpty(),
                    p => p.ClassTypeName.Contains(input.Filter)
                )
                .OrderBy(p => p.ClassTypeName)
                .ToList();

            return new ListResultDto<ClassTypeListDto>(ClassTypes.MapTo<List<ClassTypeListDto>>());
        }

        [AbpAuthorize(AppPermissions.Pages_Tenant_ClassTypes_Create)]
        public async Task CreateClassType(CreateClassTypeInput input)
        {
            var ClassType = input.MapTo<ClassType>();
            await _classTypeRepository.InsertAsync(ClassType);
        }

        [AbpAuthorize(AppPermissions.Pages_Tenant_ClassTypes_Delete)]
        public async Task DeleteClassType(EntityDto input)
        {
            await _classTypeRepository.DeleteAsync(input.Id);
        }
  
    }

}
