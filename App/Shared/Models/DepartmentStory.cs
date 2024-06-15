

using System.ComponentModel.DataAnnotations;

namespace Shared.Models
{
    public class DepartmentStory
    {
        [Key]
        public string id { get; }
        public string departmentId { get; init; }
        public string storyId { get; init; }
        public Department department { get; init; }
        public Story story { get; init; }

        public DepartmentStory()
        {
            id = Guid.NewGuid().ToString();
        }
    }
    
    
}

