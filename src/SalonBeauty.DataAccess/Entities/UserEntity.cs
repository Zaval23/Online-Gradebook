using System.ComponentModel.DataAnnotations.Schema;

namespace SalonBeauty.DataAccess.Entities;
[Table("users")]
public class UserEntity : BaseEntity
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string? Patronymic { get; set; }
    public string Telephone { get; set; }
    public string Login { get; set; }

    public virtual ICollection<UserRoleEntity> UserRoles { get; set; }
    public virtual ICollection<SignUpEntity> SignUpsClients { get; set; }
    public virtual ICollection<SignUpEntity> SignUpsMasters { get; set; }
    public virtual ICollection<ServiceUserEntity> ServiceUsers { get; set; }
}