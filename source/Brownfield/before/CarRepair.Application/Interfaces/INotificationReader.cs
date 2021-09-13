namespace CarRepair.Application.Interfaces
{
    public interface INotificationReader<out T> where T : class
    {
        T Read();
    }
}