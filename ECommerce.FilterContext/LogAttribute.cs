using ECommerce.Data.Interfaces;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Controllers;

namespace ECommerce.FilterContext
{
    public class LogAttribute: Attribute, IActionFilter
    {
     
        public LogAttribute()
        {

        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            int? userId = Helper.HttpContextHelper.Current.Session.GetInt32("UserId");
            string controller = ((ControllerActionDescriptor)context.ActionDescriptor).ControllerName;
            string action = ((ControllerActionDescriptor)context.ActionDescriptor).ActionName;
            string ipAddress = string.Empty;

            var unitOfWork= Helper.HttpContextHelper.Current.RequestServices.GetService<IUnitOfWork>();
            Data.Entities.Log log = new Data.Entities.Log()
            {
                Action=action,
                Controller=controller,
                Active=true,
                CreateDate=DateTime.UtcNow,
                IpAddress=ipAddress ,
                UserId=userId

            };

            unitOfWork.LogRepository.Insert(log);
            unitOfWork.Complete();
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {

        }

     
    }
}
