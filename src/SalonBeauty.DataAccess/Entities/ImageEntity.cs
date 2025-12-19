using System.ComponentModel.DataAnnotations.Schema;

namespace SalonBeauty.DataAccess.Entities;
[Table("images")]
public class ImageEntity : BaseEntity
{
    public string FileExtension { get; set; }
    public string FileName { get; set; }
    public byte[] Content { get; set; }
    public int ServiceId { get; set; }
    public virtual ServiceEntity Service { get; set; }
    
}