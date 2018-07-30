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
        /// <summary>
        /// 请假类型
        /// </summary>
        public int VacationType { get; set; }
        /// <summary>
        /// 请假天数
        /// </summary>
        public int VacationDays { get; set; }
        /// <summary>
        /// 请假员工
        /// </summary>
        public int UserID { get; set; }
        public virtual UserInfo UserInfo { get; set; }
        public virtual Vacation Vacation { get; set; }
    }
}
