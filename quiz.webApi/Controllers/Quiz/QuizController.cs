using Microsoft.AspNetCore.Mvc;

namespace quiz.webApi.Controllers.Quiz;

[ApiController]
[Route("quiz")]
public class QuizController  : ControllerBase
{
    public Task<IActionResult> Get() 
    {
        return Task.FromResult<IActionResult>(Ok());
    }
}

public abstract class QuizBase
{
    public string Title { get; set; } // Chemistry Quiz
    public string Id { get; set; } = Guid.NewGuid().ToString();
}
class QuizTopic : QuizBase
{
    public List<QuizQuestion> Questions { get; set; } = new List<QuizQuestion>();
}

public class QuizQuestion : QuizBase
{
    public List<QuestionOption> Options { get; set; } = new List<QuestionOption>();
    public bool IsMultichoice { get; set; } = false;
    public bool HasPicture { get; set; } = false;
    public List<string> ImageUrls { get; set; } = new List<string>();
}

public class QuestionOption : QuizBase
{
}
