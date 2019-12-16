using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LjData.Models
{
    [Table("XYINFO")]
    public partial class XyInfo
    {
        [Key]
        [Column("Mobile_Version")]
        public string mobileVersion { get; set; }
    }
}
