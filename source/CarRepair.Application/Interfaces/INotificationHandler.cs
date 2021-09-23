using System.Threading;
using System.Threading.Tasks;

namespace CarRepair.Application.Interfaces
{
    public interface INotificationHandler<in T> where T : class
    {
        void Handle(T notification, CancellationToken cancellationToken);
    }
}