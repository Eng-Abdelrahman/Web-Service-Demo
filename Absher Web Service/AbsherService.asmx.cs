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
    // [System.Web.Script.Services.ScriptService]
    public class AbsherService : System.Web.Services.WebService
    {


        [WebMethod]
        public AbshirResponseModel AbsherNationalTypeSaudi(long idNo , bool idNoSpecified ,long operatorId ,bool operatorIdSpecified ,string birthDate , string birthDateSpecified)
        {
            AbshirResponseModel abshirModel = new AbshirResponseModel() 
            {
                FirstName = "FirstName FirstName FirstName",
                NationalId = 458888559969696456,
                MiddleMame = "MiddleMame MiddleMame MiddleMame",
                LastName = "LastName LastName LastName",
                Gender = "M",
                BirthDateGreogorian = DateTime.Now,
                BirthDateHijri = "MaritialStatus ",
                MaritialStatus = "MaritialStatus MaritialStatus ",
                Nationality = "NationalityNationalityNationality",
                Occupation = "Occupation",
                NationalType = NationalType.Saudi

            };

            return abshirModel;
        }
        

        [WebMethod]
        public AbshirResponseModel AbsherNationalTypeNonSaudi(long idNo, bool idNoSpecified, long operatorId, bool operatorIdSpecified)
        {
            AbshirResponseModel abshirModel = new AbshirResponseModel()
            {
                FirstName = "FirstName FirstName FirstName",
                NationalId = 458888559969696456,
                MiddleMame = "MiddleMame MiddleMame MiddleMame",
                LastName = "LastName LastName LastName",
                Gender = "M",
                BirthDateGreogorian = DateTime.Now,
                BirthDateHijri = "MaritialStatus ",
                MaritialStatus = "MaritialStatus MaritialStatus ",
                Nationality = "NationalityNationalityNationality",
                Occupation = "Occupation",
                NationalType = NationalType.Non_Saudi

            };

            return abshirModel;
        }


    }
}
