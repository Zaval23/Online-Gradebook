using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineGradebook.DataAccess.Entities;

[Table("diary_entries")]
public class DiaryEntryEntity : BaseEntity
{
    public DateTime Date { get; set; }
    public int? Grade { get; set; }
    public string? Homework { get; set; }
    
    public int StudentId { get; set; }
    public StudentEntity Student { get; set; }
    
    public int TeacherId { get; set; }
    public TeacherEntity Teacher { get; set; }
    
    public int SubjectId { get; set; }
    public SubjectEntity Subject { get; set; }

    public DiaryEntryEntity()
    {
        
    }
}