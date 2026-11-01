using DemoAPI.Interface;

namespace DemoAPI.Implementation
{
    public class ServiceTwo : IServiceTwo
    {
        private readonly IObjectTracker _objectTracker;


        public ServiceTwo(IObjectTracker objectTracker) // Constructor DI
        {
            _objectTracker = objectTracker;
        }

        public Guid GetTrackerId()
        {
            return _objectTracker.Id;
        }
    }
}
