using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EikonSxSClassLibrary
{    
    /*Quote Q Quote
    News NEWS News
    Chart CHT Graph
    Monitor MON THOMSONREUTERS.REALTIME.THINMONITOR
    Industry App INDUS APPxINDUSTRY
    Routines RTNE THOMSONREUTERS.AIM.ROUTINES
    Option Pricer OPR APPxCALCOPR
    Seasonality Chart SEAC THOMSONREUTERS.CHARTS.SEASONALITYCHART
    All Quotes ALLQ APPxCALCALLQ
    FX Polls FXPOLLS APPxFXPOLLS
    Bond Calculator BNDC APPxCALCBNDC
    Fixed Income Monitor FINIM THOMSONREUTERS.FIXEDINCOME.FI_NIM
    */


    public class EikonApp
    {
        public string INSTANCEID { get; set; } = "";
        public bool ISLINKED { get; set; } = false;
        public JsonApp APP { get; set; }

        public EikonApp(string id, JsonApp app, bool linked = false)
        {
            INSTANCEID = id;
            APP = app;
        }

    }
}
