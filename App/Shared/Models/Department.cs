

using System.ComponentModel.DataAnnotations;

namespace Shared.Models
{
    public class Department
    {
        [Key]
        public String Id { get; }
        public String Name { get; set; }
        public String? Description { get; set; }
        public List<Story> Stories { get; } = [];

        public Department()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
    
}

