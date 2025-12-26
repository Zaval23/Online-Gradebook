using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineGradebook.DataAccess.Entities;

[Table("parent_students")]
public class ParentStudentEntity : BaseEntity
{
    public int ParentId { get; set; }
    public ParentEntity Parent { get; set; }
    
    public int StudentId { get; set; }
    public StudentEntity Student { get; set; }

    public ParentStudentEntity()
    {
        
    }
}


