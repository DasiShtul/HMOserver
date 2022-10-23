using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace DAL
{
    public partial class Maker_tbl
    {
        public MakerCommon ConvertToCommon(Maker_tbl _Maker)
        {
            MakerCommon makerCommon = new MakerCommon();
            makerCommon.MakerId = _Maker.MakerId;
            makerCommon.MakerName = _Maker.MakerName;            
            return makerCommon;
        }

        public static Maker_tbl ConvertFromCommon(MakerCommon makerCommon)
        {
            Maker_tbl m_tbl = new Maker_tbl();
            m_tbl.MakerId = makerCommon.MakerId;
            m_tbl.MakerName = makerCommon.MakerName;
            
            return m_tbl;
        }
    }
}
