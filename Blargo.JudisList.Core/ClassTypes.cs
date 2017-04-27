using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Blargo.JudisList
{
    [Table("JlClassTypes")]
    public class ClassType : FullAuditedEntity
    {

        public const int MaxClassTypeNameLength = 20;

        [Required]
        [MaxLength(MaxClassTypeNameLength)]
        public virtual string ClassTypeName { get; set; }

    }
}
