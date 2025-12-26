using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineGradebook.DataAccess.Entities;

[Table("teachers")]
public class TeacherEntity : BaseEntity
{
    public string Classroom { get; set; }
    
    public int UserId { get; set; }
    public UserEntity User { get; set; }
    
    public virtual ICollection<DiaryEntryEntity> DiaryEntries { get; set; }

    public TeacherEntity()
    {
        
    }
}


