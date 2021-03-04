using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Student_Details_Mvcc.Models
{
    public class Viewmodel
    {
        public  Studentmodel employee { get; set; }
        public Markmodel department { get; set; }
        public int Rank { get; set; }

       
    }
}