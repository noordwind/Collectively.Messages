namespace Collectively.Messages.Events
{
    public class Resource
    {
        public string Service { get; protected set; }
        public string Endpoint { get; protected set; }

        protected Resource()
        {
        }

        protected Resource(string service, string endpoint)
        {
            Service = service.ToLowerInvariant();
            Endpoint = endpoint.ToLowerInvariant();
        }

        public static Resource Create(string service, string endpoint)
            => new Resource(service, endpoint);
    }
}