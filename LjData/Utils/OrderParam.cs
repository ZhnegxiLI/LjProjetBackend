using System;
using System.Collections.Generic;
using System.Text;

namespace LjData.Models
{
    public class OrderParam
    {
        public string receiver { get; set; }
        public string dept { get; set; }
        public string type { get; set; } //订单种类 I表示采购 0 表示销售
        public string faxReceiver { get; set; }
        public string telReceiver { get; set; }
        public string sender { get; set; }
        public string telSender { get; set; }
        public string faxSender { get; set; }
        public string descript { get; set; }
        public string remarkfeedback { get; set; }
        public string deptId { get; set; }
        public string userId { get; set; }
        public string messageForAuditor { get; set; }
        public string status { get; set; }
        public int statusCode { get; set; }
        public string title { get; set; }
        public DateTime? date { get; set; }
        public string seal { get; set; }
        public bool copyAfterCheck { get; set; }
        public string remarkCorrige { get; set; }

        public string entrepriseName { get; set; }
    }
}
