using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TwilioAPI.Entities
{
    public class SMSSetting
    {
        public string AccountSID { get; set; } = null!;
        public string AuthToken { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
    }
}