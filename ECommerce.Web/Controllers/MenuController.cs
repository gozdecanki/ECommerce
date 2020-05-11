using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerce.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Web.Controllers
{
    public class MenuController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public MenuController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        [FilterContext.Log]
        [FilterContext.Auth(Data.Enum.UserTitle.Customer)]
        [Route("/menu/getir")]
        public IActionResult Get()
        {
            var menus = _unitOfWork.MenuRepository.List();
            return View(menus);
        }
    }
}