using RuiHua.Models;
using RuiHuaComponents.Repositories.Ef;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RuiHua.Controllers
{
    public class HomeController : Controller
    {
        public RuiHuaDbContext _db = new RuiHuaDbContext();
        public ActionResult Index()
        {
        
            var userInfo = _db.UserInfo.ToList();
           var vacation = _db.Vacation.ToList();
         var data=   _db.Database.SqlQuery<UserVacationDetailModel>("select u.ID,u.UserName,v.VacationType,sum(v.VacationDays) VacationDays from VacationDetails  v inner join UserInfo u on v.UserID=u.ID group by  u.UserName,v.vacationtype,u.ID").ToList();
            IndexViewModel model = new IndexViewModel()
            {
                UserInfos = userInfo,
                Vacation = vacation,
                UserVacationDetailModelList = data
            };
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}