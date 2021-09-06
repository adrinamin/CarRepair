using System.Threading;
using System.Threading.Tasks;

namespace CarRepair.Application
{
    public interface INotificationHandler<in T> where T : class
    {
        Task Handle(T notification, CancellationToken cancellationToken);
    }
}