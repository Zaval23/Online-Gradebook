namespace SalonBeauty.DataAccess.Entities;

public class UserRoleEntity : BaseEntity
{
    public int UserId { get; set; }
    public UserEntity UserEntity { get; set; }
    public int RoleId { get; set; }
    public RoleEntity RoleEntity { get; set; }
}