using System;

namespace CarBMW.MVC.Models
{
    public class ErrorViewModel
    {
        int a = 0;
        public string RequestId { get; set; }
            
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
