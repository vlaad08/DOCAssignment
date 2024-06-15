using Shared.Models;

public interface IStoryLogic
{
    Task<Story> CreateStory(Story story, string departmentId);
    Task<Story?> GetStory(string id);
    Task<IEnumerable<Story>> GetStories(string departmentId);

    Task DeleteStory(string id);
}