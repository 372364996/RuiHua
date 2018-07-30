using RuiHuaComponents.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RuiHua.Models
{
    public class IndexViewModel
    {
        public List<Vacation> Vacation { get; set; }
        public List<UserInfo> UserInfos { get; set; }
        public List<UserVacationDetailModel> UserVacationDetailModelList { get; set; }
    }
    public class UserVacationDetailModel
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public int VacationType { get; set; }
        public int VacationDays { get; set; }
    }
}