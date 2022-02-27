namespace LjDataAccess.Interfaces
{
    public interface IUtils
    {
        string GetOrdersStatus(int code);

        string GetCommandTypeLabelById(string commandeTypeId);
    }
}
