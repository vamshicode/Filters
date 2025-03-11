using Microsoft.AspNetCore.Mvc.Filters;

namespace Filters
{
    public class MySampleAsyncActionFilterAttribute : Attribute,IAsyncActionFilter
    {
        public string _name { get; set; }
        public MySampleAsyncActionFilterAttribute(string name)
        {
            _name = name;
        }
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            Console.WriteLine($"Before async execution {_name}");
            await next();
            Console.WriteLine($"After async execution {_name}");

        }
    }
}
