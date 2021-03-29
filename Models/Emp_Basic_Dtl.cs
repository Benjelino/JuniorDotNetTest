using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JuniorDotNetTest.Models
{
    public class Emp_Basic_Dtl
    {
        public int Emp_ID { get; set; }
        public string Emp_code { get; set; }
        public string Emp_Name { get; set; }
        public DateTime DoJ { get; set; }
        public DateTime Created_Date { get; set; }
    }
}