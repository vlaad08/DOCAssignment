

using System.ComponentModel.DataAnnotations;

namespace Shared.Models
{
    public class Department
    {
        [Key]
        public string id { get; }
        public string name { get; init; }
        public string? description { get; init; }

        public Department()
        {
            id = Guid.NewGuid().ToString();
        }
    }
    
}

