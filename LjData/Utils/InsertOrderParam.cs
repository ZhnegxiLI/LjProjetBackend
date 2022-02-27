using System.Collections.Generic;

namespace LjData.Models
{
    public class InsertOrderParam
    {
        public OrderParam orderInfo { get; set; }
        public List<ProductParam> products { get; set; }

    }
}
