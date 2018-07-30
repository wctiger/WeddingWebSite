using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Filters;

namespace WeddingAPI.Filters
{
    public class MyExceptionFilter : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext context)
        {
            string msg = context.Exception.Message;
            string stacktrace = context.Exception.StackTrace;
            base.OnException(context);
        }
    }
}