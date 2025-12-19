namespace SalonBeauty.DataAccess.Entities;

public class ServiceUserEntity : BaseEntity
{
    public int ServiceId { get; set; }
    public ServiceEntity ServiceEntity { get; set; }
    
    public int UserId { get; set; }
    public UserEntity UserEntity { get; set; }
}