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
        [Column("FAX_CI")]
        public string entrepriseFax { get; set; }
        [Column("PHON_CI")]
        public string entrepriseTel { get; set; }
    }
}
