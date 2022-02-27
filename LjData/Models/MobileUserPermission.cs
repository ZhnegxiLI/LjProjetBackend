using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LjData.Models
{
    [Table("Mobile_User_Permission")]
    public partial class MobileUserPermission
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public int PermissionId { get; set; }
    }
}
