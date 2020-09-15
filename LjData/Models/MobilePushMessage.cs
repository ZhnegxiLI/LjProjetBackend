using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LjData.Models
{
    [Table("Mobile_PushMessage")]
    public class MobilePushMessage
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public string UserEmail { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string UserGroup { get; set; }

        public Boolean IsSend { get; set; }
    }
}
