using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JuniorDotNetTest.Models
{
    public class Emp_Qualification_Dtl
    {
        public int Emp_ID { get; set; }
        public string Qualification { get; set; }
        public string Completed_year { get; set; }
        public int Grade { get; set; }
        public DateTime Created_Date { get; set; }
    }
}