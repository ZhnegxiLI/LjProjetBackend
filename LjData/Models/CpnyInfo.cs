using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace LjData.Models
{
    [Table("CPNYINFO")]
    public partial class CpnyInfo
    {
        [Key]
        [Column("CPNY_CI")]
        [JsonProperty]
        public string entrepriseType { get; set; }
        [Column("CNAM_CI")]
        [JsonProperty]
        public string entrepriseName { get; set; }
        [Column("FAX_CI")]
        [JsonProperty]
        public string entrepriseFax { get; set; }
        [Column("PHON_CI")]
        [JsonProperty]
        public string entrepriseTel { get; set; }
    }
}
