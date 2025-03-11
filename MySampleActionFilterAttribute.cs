using Microsoft.AspNetCore.Mvc.Filters;
namespace Filters
{
    public class MySampleActionFilterAttribute : Attribute, IActionFilter, IOrderedFilter
    {
        public readonly string _name;
        public int Order { get; set; }

        public MySampleActionFilterAttribute(string name, int order=1)
        {
            this._name = name;
            Order = order;
        }
        public void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine($"OnActionExecuting- {_name}");
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine($"OnActionExecuted- {_name}");
        }


    }
}
