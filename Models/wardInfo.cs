using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace info.Models
{
    public class wardInfo
    {
        [Key]
        public int ID { get; set; }
        public string name { get; set; }
        public string work { get; set; }
        public string phone { get; set; }
        [EmailAddress]
        public string email { get; set; }
        public string twitter { get; set; }
    }
}