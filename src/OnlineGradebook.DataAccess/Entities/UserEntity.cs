using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineGradebook.DataAccess.Entities;
[Table("users")]
public class UserEntity : BaseEntity
{
    public string Email { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string? MiddleName { get; set; }
    
    public int RoleId { get; set; }
    public RoleEntity Role { get; set; }

    public virtual StudentEntity? Student { get; set; }
    public virtual TeacherEntity? Teacher { get; set; }
    public virtual ParentEntity? Parent { get; set; }
}