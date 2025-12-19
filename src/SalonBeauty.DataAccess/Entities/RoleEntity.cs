using System.ComponentModel.DataAnnotations.Schema;
namespace SalonBeauty.DataAccess.Entities;
[Table("roles")]
public class RoleEntity:BaseEntity
{
    public Role Role{get;set;}
    public virtual ICollection<UserRoleEntity> UserRoles { get; set; }
    
}