using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuiHuaComponents.Domains
{
    /// <summary>
    /// 请假详情    
    /// </summary>
  public     class VacationDetail
    {
        /// <summary>
        /// 请假详情Id
        /// </summary>
        public int ID { get; set; }
        public int VacationType { get; set; }
        public int VacationDays { get; set; }
        public int UserID { get; set; }
        public virtual UserInfo UserInfo { get; set; }
        public virtual Vacation Vacation { get; set; }
    }
}
