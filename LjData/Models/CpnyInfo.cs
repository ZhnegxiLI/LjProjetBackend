using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LjData.Models
{
    [Table("CPNYINFO")]
    public partial class CpnyInfo
    {
        [Key]
        [Column("CNAM_CI")]
        public string entrepriseName { get; set; }
    }
}
