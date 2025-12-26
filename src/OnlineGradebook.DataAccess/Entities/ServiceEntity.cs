using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineGradebook.DataAccess.Entities;
[Table("subjects")]

public class SubjectEntity : BaseEntity
{
    public string NameOfSubject { get; set; }
    
    public virtual ICollection<DiaryEntryEntity> DiaryEntries {get;set;}

    public SubjectEntity()
    {
        
    }
}