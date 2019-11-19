using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;

namespace LjData.Models
{
    public class InsertOrderParam
    {
        public OrderParam orderInfo { get; set; }
        public List<ProductParam> products { get; set; }

    }
}
