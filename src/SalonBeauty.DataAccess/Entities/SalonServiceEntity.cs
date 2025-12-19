namespace SalonBeauty.DataAccess.Entities;

public class SalonServiceEntity : BaseEntity
{
    public int SalonId { get; set; }
    public SalonEntity SalonEntity { get; set; }
    
    public int ServiceId { get; set; }
    public ServiceEntity ServiceEntity { get; set; }
}