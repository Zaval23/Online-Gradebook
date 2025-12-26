using System.ComponentModel.DataAnnotations.Schema;
namespace OnlineGradebook.DataAccess.Entities;
[Table("roles")]
public class RoleEntity:BaseEntity
{
    public string RoleName { get; set; }
    public string? Description { get; set; }
    public virtual ICollection<UserEntity> Users { get; set; }

    public RoleEntity()
    {
        
    }
}