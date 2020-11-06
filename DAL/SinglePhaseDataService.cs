using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
    public class SinglePhaseDataService
    {
        public int AddSinglePhaseData(SinglePhaseData sPData)
        {
            string sql = "insert into SinglePhaseData(PhaseNumber,rednum1,rednum2,rednum3,rednum4,rednum5,rednum6,bluenum,'PhaseDatetime')";
            sql += $" values({sPData.PhaseNumber},{sPData.ProduceNumbers[0].Numbers[0]},{sPData.ProduceNumbers[0].Numbers[1]},{sPData.ProduceNumbers[0].Numbers[2]},{sPData.ProduceNumbers[0].Numbers[3]},{sPData.ProduceNumbers[0].Numbers[4]},{sPData.ProduceNumbers[0].Numbers[5]},{sPData.ProduceNumbers[0].Numbers[6]},'{sPData.PhaseDatetime}')";
            return SQLHelper.Update(sql);


        }
    }
}
