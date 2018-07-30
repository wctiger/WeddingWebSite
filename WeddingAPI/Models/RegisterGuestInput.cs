using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeddingAPI.Models
{
    public class RegisterGuestInput
    {
        public string Email { get; set; }
        public string Code { get; set; }
        public int NumAdults { get; set; }
        public int NumKids { get; set; }
        public string Message { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}