using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagementSystem.Models
{
    public class Machine
    {
        public string Id { get; set; }
        public string MachineName { get; set; }
        // Bool prop for ON/OFF
        public bool Status { get; set; }
        public string Data { get; set; }
    }
}
