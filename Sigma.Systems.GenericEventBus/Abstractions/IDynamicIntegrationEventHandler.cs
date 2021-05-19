using System.Threading.Tasks;

namespace Sigma.Systems.GenericEventBus.Abstractions
{
    public interface IDynamicIntegrationEventHandler
    {
        Task Handle(dynamic eventData);
    }
}
