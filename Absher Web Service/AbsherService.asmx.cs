using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Absher_Web_Service
{
    /// <summary>
    /// Summary description for AbsherService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class AbsherService : System.Web.Services.WebService
    {


        [WebMethod]
        public AbshirResponseModel AbsherNationalTypeSaudi(long idNo , bool idNoSpecified ,long operatorId ,bool operatorIdSpecified ,string birthDate , bool birthDateSpecified)
        {
            return RandomData.RandomDataGenerator();
        }
        

        [WebMethod]
        public AbshirResponseModel AbsherNationalTypeNonSaudi(long idNo, bool idNoSpecified, long operatorId, bool operatorIdSpecified)
        {
            return RandomData.RandomDataGenerator();
        }


    }
}
