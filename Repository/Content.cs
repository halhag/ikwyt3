using System;

namespace Repository
{
    public class Content
    {
        public Guid ContentId { get; set; }
        public string Json { get; set; }
        public string ContentType { get; set; }
        public string ExternalReference { get; set; }
    }
}
