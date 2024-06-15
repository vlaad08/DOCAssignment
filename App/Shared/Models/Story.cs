
using System.ComponentModel.DataAnnotations;

namespace Shared.Models
{ 
    public class Story
    {
        [Key]
        public string id { get; }
        public string title { get; init; }
        public string body { get; init; }

        public Story()
        {
            id = Guid.NewGuid().ToString();
        }
    }
}
