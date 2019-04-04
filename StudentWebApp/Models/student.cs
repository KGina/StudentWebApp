using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentWebApp.Models
{
    public class student
    {
        public int std_ID { get; set; }
        public int studentNumber { get; set; }
        public string studentName { get; set; }
        public string  surname { get; set; }
        public string email { get; set; }
        public string telphone_No { get; set; }
        public string mobile { get; set; }
        public string reg_Status { get; set; }
    }
   
    
}