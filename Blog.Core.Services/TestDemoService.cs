using Blog.Core.IRepository.Base;
using Blog.Core.IServices;
using Blog.Core.Model.Models;
using Blog.Core.Services.BASE;

namespace Blog.Core.Services;

public class TestDemoService : BaseServices<TestDemo>, ITestDemoService
{
    private readonly IBaseRepository<TestDemo> _testDemoRepository;
    public TestDemoService(IBaseRepository<TestDemo> testDemoRepository)
    {
        _testDemoRepository = testDemoRepository;
    }
}