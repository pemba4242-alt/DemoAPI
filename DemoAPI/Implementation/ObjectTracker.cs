using DemoAPI.Interface;

namespace DemoAPI.Implementation
{
    public class ObjectTracker : IObjectTracker
    {
        public Guid Id { get; } = Guid.NewGuid();
    }
}
