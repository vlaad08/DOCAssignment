using DBConnection.Context;
using Microsoft.EntityFrameworkCore;
using Shared.Models;

public class StoryRepository : IStoryRepository
{
    private TabloidContext context;

    public StoryRepository(TabloidContext context)
    {
        this.context = context;
    }
    public async Task<Story> CreateStory(Story story, string departmentId)
    {
        var s = await context.story.AddAsync(story);
        await context.departmentStory.AddAsync(new DepartmentStory { departmentId = departmentId, storyId = s.Entity.id });
        await context.SaveChangesAsync();
        return s.Entity;
    }

    public async Task DeleteStory(string id)
    {
        await context.departmentStory.Where(ds => ds.storyId == id).ForEachAsync(ds => context.departmentStory.Remove(ds));
        var story = await context.story.FirstOrDefaultAsync(s => s.id == id);
        context.story.Remove(story);
        await context.SaveChangesAsync();
    }

    public async Task<IEnumerable<Story>> GetStories(string departmentId)
    {
        return await context.departmentStory
            .Where(ds => ds.departmentId == departmentId)
            .Join(context.story, ds => ds.storyId, s => s.id, (ds, s) => s)
            .ToListAsync();
    }

    public Task<Story?> GetStory(string id)
    {
        return context.story.FirstOrDefaultAsync(s => s.id == id);
    }
}