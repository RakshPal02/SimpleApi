using Xunit;
using SimpleApi.Controllers;
namespace SimpleApi.tests;

public class UnitTest1
{
    ValuesController objValuesCnt=new ValuesController();
    [Fact]
    public void Test1()
    {
var ctr=objValuesCnt.Get(1);
Assert.Equal("Raksh pal",ctr);
    }
}