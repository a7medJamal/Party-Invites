using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Party_Invites.Models
{
    public class GestResponse
    {
        public string Name { set; get; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool? WillAttend { get; set; }
    }
}