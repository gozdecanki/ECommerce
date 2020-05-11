using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerce.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Web.Controllers
{
    public class LogController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public LogController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [FilterContext.Log]
        [FilterContext.Auth(Data.Enum.UserTitle.Administrator)]
        public IActionResult Index()
        {
            return View();
        }


        [FilterContext.Log]
        [FilterContext.Auth(Data.Enum.UserTitle.Administrator)]
        [Route("/log/getir")]
        public IActionResult GetAll()
        {
            var logs = _unitOfWork.LogRepository
                .Query()
                .Include(a => a.User)
                .ToList();

            return new JsonResult(logs);
        }
    }
}