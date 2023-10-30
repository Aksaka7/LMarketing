using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AlistirmaDers3API.Context.Domain
{
    public class UserRoles
    {
       
            [Key]
            public Guid Id { get; set; }
            public Guid UserId { get; set; }
            [ForeignKey("UserId")]
            public virtual Register User { get; set; }
            public string Role { get; set; }
       
    }
}
