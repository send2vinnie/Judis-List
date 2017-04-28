using System.ComponentModel.DataAnnotations;
using Abp.AutoMapper;

namespace Blargo.JudisList.ClassTypes.Dto
{
    [AutoMapTo(typeof(ClassType))]
    public class CreateClassTypeInput
    {

        [Required]
        [MaxLength(ClassType.MaxClassTypeNameLength)]
        public string ClassTypeName { get; set; }

    }
}
