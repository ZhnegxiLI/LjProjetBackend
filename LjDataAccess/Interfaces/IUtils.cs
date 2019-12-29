using System;
using System.Collections.Generic;
using System.Text;

namespace LjDataAccess.Interfaces
{
    public interface IUtils
    {
        string GetOrdersStatus(int code);

        string GetCommandTypeLabelById(string commandeTypeId);
    }
}
