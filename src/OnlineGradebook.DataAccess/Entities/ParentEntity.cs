using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineGradebook.DataAccess.Entities;

[Table("parents")]
public class ParentEntity : BaseEntity
{
    public int UserId { get; set; }
    public UserEntity User { get; set; }
    
    public virtual ICollection<ParentStudentEntity> ParentStudents { get; set; }

    public ParentEntity()
    {
        
    }
}


