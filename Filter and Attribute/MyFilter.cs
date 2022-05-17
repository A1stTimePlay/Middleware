using Microsoft.AspNetCore.Mvc.Filters;

namespace Filter_and_Attribute
{
    public class MyFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine("On Global Filter Executed");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine("On Global Filter Executing");
        }
    }
}
