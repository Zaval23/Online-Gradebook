using System.ComponentModel.DataAnnotations.Schema;

namespace SalonBeauty.DataAccess.Entities;

[Table("signs_up")]
public class SignUpEntity : BaseEntity
{
    public DateTime DateTime{get; set;}
    
    public int ClientId { get; set; }
    public UserEntity Client { get; set; }
    
    public int MasterId { get; set; }
    public UserEntity Master { get; set; }
    
    public int ServiceId { get; set; }
    public ServiceEntity ServiceEntity { get; set; }
    
}