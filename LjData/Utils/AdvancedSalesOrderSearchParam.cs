﻿using System;
using System.Collections.Generic;

namespace LjData.Models
{
    public class AdvancedSalesOrderSearchParam
    {
        public AdvancedSalesOrderSearchParam()
        {
            this.userIds = userIds == null ? new List<string>() : userIds;
            this.orderTypes = orderTypes == null ? new List<string>() : orderTypes;
            this.orderStatus = orderStatus == null ? new List<string>() : orderStatus;
        }
        public virtual List<string> userIds { get; set; }
        public virtual List<string> orderTypes { get; set; }
        public virtual List<string> orderStatus { get; set; }
        public virtual string orderId { get; set; }
        public virtual DateTime? fromDate { get; set; }
        public virtual DateTime? toDate { get; set; }
        public virtual int step { get; set; }
        public virtual int begin { get; set; }
    }
}
