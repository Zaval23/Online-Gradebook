using System.ComponentModel.DataAnnotations.Schema;

namespace SalonBeauty.DataAccess.Entities;
[Table("services")]

public class ServiceEntity : BaseEntity
{
    public string Name { get; set; }
    public int Price { get; set; }
    
    public virtual ICollection<ServiceUserEntity> ServiceUsers{get;set;}
    public virtual ICollection<SignUpEntity> SignUps {get;set;}
    public virtual ICollection<SalonServiceEntity> SalonServices {get;set;}
    public virtual ICollection<ImageEntity> Images { get; set; }
    
}