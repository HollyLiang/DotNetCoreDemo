using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class UploadController : ControllerBase
{
    [HttpPost]
    public IActionResult Upload([FromForm] UploadModel model)
    {
        return Ok(model.Files.Count);
    }
}