using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Essai_WebApplicationMVC.Models
{
    public class GuestResponse
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool? WillAttend { get; set; }
        public bool? Confirmation { get; set; }


    }
}
