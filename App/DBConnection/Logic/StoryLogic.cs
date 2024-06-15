using Shared.Models;

public class StoryLogic : IStoryLogic
{

    private IStoryRepository repository;

    public StoryLogic(IStoryRepository repository)
    {
        this.repository = repository;
    }

    public async Task<Story> CreateStory(Story story, string departmentId)
    {
        return await repository.CreateStory(story, departmentId);
    }

    public async Task DeleteStory(string id)
    {
        await repository.DeleteStory(id);
    }

    public async Task<IEnumerable<Story>> GetStories(string departmentId)
    {
        return await repository.GetStories(departmentId);
    }

    public async Task<Story?> GetStory(string id)
    {
        return await repository.GetStory(id);   
    }
}