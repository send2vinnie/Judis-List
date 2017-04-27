using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Blargo.JudisList.MultiTenancy.Dto;

namespace Blargo.JudisList.Web.Areas.Mpa.Models.Tenants
{
    public class EditTenantViewModel
    {
        public TenantEditDto Tenant { get; set; }

        public IReadOnlyList<ComboboxItemDto> EditionItems { get; set; }

        public EditTenantViewModel(TenantEditDto tenant, IReadOnlyList<ComboboxItemDto> editionItems)
        {
            Tenant = tenant;
            EditionItems = editionItems;
        }
    }
}