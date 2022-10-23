using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace DAL
{
    public partial class StatusCOVID19_tbl
    {
        public StatusCOVID19Common ConvertToCommon(StatusCOVID19_tbl _StatusCOVID19)
        {
            StatusCOVID19Common statusCOVID19Common = new StatusCOVID19Common();
            statusCOVID19Common.PatientId = _StatusCOVID19.PatientId;
            statusCOVID19Common.Positive = _StatusCOVID19.Positive;
            statusCOVID19Common.Recovery = _StatusCOVID19.Recovery;           
           
            return statusCOVID19Common;
        }

        public static StatusCOVID19_tbl ConvertFromCommon(StatusCOVID19Common statusCOVID19Common)
        {
            StatusCOVID19_tbl s_tbl = new StatusCOVID19_tbl();
            s_tbl.PatientId = statusCOVID19Common.PatientId;
            s_tbl.Positive = statusCOVID19Common.Positive;
            s_tbl.Recovery = statusCOVID19Common.Recovery;
            
            return s_tbl;
        }
    }
}
