using System;
using System.Linq;

namespace Collectively.Messages.Commands
{
    public class Request
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Origin { get; set; }
        public string Resource { get; set; }
        public string Culture { get; set; }
        public DateTime CreatedAt { get; set; }

        public static Request From<T>(Request request)
            => Create<T>(request.Id, request.Origin, request.Culture, request.Resource);

        public static Request New<T>() => New<T>(Guid.NewGuid());

        public static Request New<T>(Guid id) => Create<T>(id, string.Empty, string.Empty);

        public static Request Create<T>(Guid id, string origin, string culture, string resource = "")
            => new Request
            {
                Id = id,
                Name = GetName(typeof(T).Name),
                Origin = origin.StartsWith("/") ? origin.Remove(0, 1) : origin,
                Culture = culture,
                Resource = resource,
                CreatedAt = DateTime.UtcNow
            };

        private static string GetName(string name)
            => Underscore(name).ToLowerInvariant();

        private static string Underscore(string value)
            => string.Concat(value.Select((x,i) => i > 0 && char.IsUpper(x) ? "_" + x.ToString() : x.ToString())); 
    }
}