using Portfolio.Models;
using System.Collections.Generic;
using System.EnterpriseServices.Internal;

public class StudentProfile
{
    public int Id { get; set; }
     public string FullName { get; set; }
    public string Title { get; set; }
    public string Summary { get; set; }
    public string Email { get; set; }
    public string Location { get; set; }
// imagen o avatar 
    public string ProfileImageUrl {get; set;}

    public virtual ICollection<Education> Education { get; set; }
    public virtual ICollection<Experience> Experience { get; set; }
    public virtual ICollection<Skills> Skills { get; set; }
    public virtual ICollection<Projects> Projects { get; set; }
    public virtual ICollection<SocialLinks> SocialLinks { get; set; }

}