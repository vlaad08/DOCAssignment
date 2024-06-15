using Microsoft.AspNetCore.Mvc;
using Shared.Models;

namespace WebApi.Controllers;

[ApiController]
[Route("stories")]
public class StoryController
{
    private readonly IConfiguration configuration;
    private readonly IStoryLogic storyLogic;

    public StoryController(IConfiguration configuration, IStoryLogic storyLogic)
    {
        this.configuration = configuration;
        this.storyLogic = storyLogic;
    }

    [HttpPost, Route("")]
    public async Task<ActionResult<Story>> CreateStory([FromBody] CreateStoryInput story)
    {
        var input = new Story
        {
            title = story.Title,
            body = story.Body,
        };
        var newStory = await storyLogic.CreateStory(input, story.DepartmentId);
        return newStory;
    }

    [HttpGet, Route("departments/{departmentId}")]
    public async Task<ActionResult<IEnumerable<Story>>> GetStories([FromRoute] string departmentId)
    {
        var stories = await storyLogic.GetStories(departmentId);
        return stories.ToList();
    }

    [HttpGet, Route("{id}")]
    public async Task<ActionResult<Story>> GetStory(string id)
    {
        var story = await storyLogic.GetStory(id);
        if (story == null)
        {
            throw new Exception("Story not found");
        }
        return story;
    }

    [HttpDelete, Route("{id}")]
    public async Task<ActionResult<SuccessfulResponse>> DeleteStory(string id)
    {
        try{
            await storyLogic.DeleteStory(id);
            return new SuccessfulResponse { Success = true, Message = "Story deleted successfully" };
        }
        catch(Exception e){
            return new SuccessfulResponse { Success = false, Message = e.Message };
        }
    }

}