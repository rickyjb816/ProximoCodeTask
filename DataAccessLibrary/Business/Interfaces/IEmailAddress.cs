namespace DataAccessLibrary.Business
{
    public interface IEmailAddress
    {
        Task Delete(int ID, string Type);
    }
}