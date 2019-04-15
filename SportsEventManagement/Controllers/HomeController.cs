using SportsEventManagement.Data.Infrastructure;
using SportsEventManagement.DbModels.EF;
using SportsEventManagement.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportsEventManagement.Controllers
{
    public class HomeController : Controller
    {
        private IUnitOfWork _unitOfWork;
        public HomeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            //IUnitOfWork ui = new UnitOfWork();
            Student st = new Student();
            st.Name = "Fahad";
            _unitOfWork.StudentRepository.Add(st);
            _unitOfWork.StudentRepository.Add(st);
            _unitOfWork.Commit();
            _unitOfWork.Commit();
            return View();
        }
    }
}
