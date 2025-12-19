using System.ComponentModel.DataAnnotations.Schema;

namespace SalonBeauty.DataAccess.Entities;

[Table("salons")]
public class SalonEntity : BaseEntity
{
    public string Adress { get; set; }
    public virtual ICollection<SalonServiceEntity> SalonServices { get; set; }
    
}