using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Absher_Web_Service
{
    public class AbshirResponseModel
    {
        public string FullName { get; set; }
        public long NationalId { get; set; }
        public string FirstName { get; set; }
        public string MiddleMame { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDateGreogorian { get; set; }
        public string BirthDateHijri { get; set; }
        public string MaritialStatus { get; set; }
        public string Nationality { get; set; }
        public string Occupation { get; set; }
        public NationalType NationalType { get; set; }
    }


    public enum NationalType 
    {
        Saudi,
        Non_Saudi
    }
}