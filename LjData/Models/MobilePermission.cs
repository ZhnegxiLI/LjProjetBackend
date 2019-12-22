using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LjData.Models
{
    [Table("Mobile_Permission")]
    public partial class MobilePermission
    {
        [Key]
        public int Id { get; set; }
        public string Code { get; set; }
        public string Label { get; set; }
    }
}
