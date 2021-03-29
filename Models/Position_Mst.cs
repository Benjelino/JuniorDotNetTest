using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JuniorDotNetTest.Models
{
    public class Position_Mst
    {
        public int Position_Code { get; set; }
        public string Position_Desc { get; set; }
        public string Position_Status { get; set; }
        public DateTime Created_Date { get; set; }

    }
}