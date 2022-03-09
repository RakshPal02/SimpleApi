using Microsoft.AspNetCore.Mvc;
namespace SimpleApi.Controllers
{
    public class ValuesController: ControllerBase
    {
        [HttpGet("{id}")]
       public string Get(int id){
           return "Raksh pal";
       }
    }
}