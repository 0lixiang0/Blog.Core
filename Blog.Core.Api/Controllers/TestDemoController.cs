using Blog.Core.Controllers;
using Blog.Core.IServices;
using Blog.Core.Model;
using Blog.Core.Model.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Core.Api.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
//[Authorize(Permissions.Name)]
public class TestDemoController : BaseApiController
{
    public ITestDemoService _testDemoService { get; set; }
    private readonly ILogger<TestDemoController> _logger;

    public TestDemoController(ITestDemoService testDemoService, ILogger<TestDemoController> logger)
    {
        _testDemoService = testDemoService;
        _logger = logger;
    }
    
    [HttpPost]
    public async Task<MessageModel<string>> Post([FromBody] TestDemo request)
    {
        request.Id = Guid.NewGuid();
        var result = (await _testDemoService.AddTEntity(request));
        return result != null ? Success<string>(result.Id.ToString()) : Failed("添加失败");
    }
}