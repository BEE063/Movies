using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApp.Filters
{
    public class IncorrectAge : Attribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var formDate = DateTime.Parse(context.HttpContext.Request.Form["DateOfBirth"]);
            if (DateTime.Parse("01.01.2013") < formDate || formDate < DateTime.Parse("01.01.1921"))
            {
                context.Result = new BadRequestResult();
            }
        }
    }
}
