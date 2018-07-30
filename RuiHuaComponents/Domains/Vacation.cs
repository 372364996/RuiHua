using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuiHuaComponents.Domains
{
    /// <summary>
    /// 请假类型
    /// </summary>
    public class Vacation
    {
        /// <summary>
        /// 请假类型ID
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 请假类型名称
        /// </summary>
        public string Name { get; set; }
        public List<VacationDetail> VacationDetails { get; set; }
    }
}
