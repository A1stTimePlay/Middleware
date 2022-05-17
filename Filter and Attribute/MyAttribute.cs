using Microsoft.AspNetCore.Mvc.Filters;

namespace Filter_and_Attribute
{
    public class MyAttribute : Attribute, IActionFilter
    {
        private readonly string _name;
        public MyAttribute(string name)
        {
            _name = name;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine("On Executed " + _name);
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine("On Executing " + _name);
        }
    }
}
