using SqlSugar;

namespace Blog.Core.Model.Models;

[SugarTable("TestDemo", TableDescription = "测试表")]
public class TestDemo : RootEntityTkey<Guid>
{
    /// <summary>
    /// 测试demo名称
    /// </summary>
    [SugarColumn(Length = 100, IsNullable = true)]
    public string TestName { get; set; }
    
    /// <summary>
    /// 测试版本
    /// </summary>
    [SugarColumn(Length = 100, IsNullable = true)]
    public string Version { get; set; }
}