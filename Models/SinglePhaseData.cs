using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class SinglePhaseData
    {
        /// <summary>
        /// 期号
        /// </summary>
        public int PhaseNumber { get; set; }
        /// <summary>
        /// 当期产生的号码
        /// </summary>
        public List<DoubleColorBall> ProduceNumbers { get; set; }
        /// <summary>
        /// 当期开奖日期
        /// </summary>
        public DateTime PhaseDatetime { get; set; }
    }
}
