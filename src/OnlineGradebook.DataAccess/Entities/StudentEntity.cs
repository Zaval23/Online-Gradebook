using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineGradebook.DataAccess.Entities;

[Table("students")]
public class StudentEntity : BaseEntity
{
    public string Class { get; set; }
    
    public int UserId { get; set; }
    public UserEntity User { get; set; }
    
    public virtual ICollection<ParentStudentEntity> ParentStudents { get; set; }
    public virtual ICollection<DiaryEntryEntity> DiaryEntries { get; set; }

    public StudentEntity()
    {
        
    }
}


