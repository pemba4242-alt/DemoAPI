using DemoAPI.Interface;

namespace DemoAPI.Implementation
{
    public class ServiceOne : IServiceOne
    {
        private readonly IObjectTracker _objectTracker;


        public ServiceOne(IObjectTracker objectTracker) // Constructor DI
        {
            _objectTracker = objectTracker;
        }

        public Guid GetTrackerId()
        {
            return _objectTracker.Id;
        }
    }
}
