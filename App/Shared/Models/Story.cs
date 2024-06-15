
namespace Shared.Models
{
    
    public class Story
    {
        public String Id { get; }
        public String Title { get; set; }
        public String Body { get; set; }
        public List<Story> Stories { get; } = [];

        public Story()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
