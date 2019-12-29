using LjDataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LjDataAccess.Repositories
{
    public class Utils : IUtils
    {
        public string GetOrdersStatus(int code)
        {
            switch (code)
            {
                case 0:
                    return "未提交";
                case 1:
                    return "提交到财务";
                case 2:
                    return "财务不同意";
                case 3:
                    return "财务同意";
                case 4:
                    return "经理不同意";
                case 5:
                    return "经理同意";
                case 6:
                    return "已作废";
                case 7:
                    return "冲单";
                default:
                    return "未定义状态";
            }
        }

        public string GetCommandTypeLabelById(string commandeTypeId)
        {
            string label = "";
            switch (commandeTypeId)
            {
                case "I":
                    label = "采购订单";
                    break;
                case "O":
                    label = "销售订单";
                    break;
                default:
                    label = "订单";
                    break;
            }

            return label;

        }
    }
}
