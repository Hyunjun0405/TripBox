using System;

namespace WebAPI.Models
{
    public class RequstStatus
    {
        public Error error { get; set; }
        public bool success { get; set; }
        public string version { get; set; }
        public Warning warning { get; set; }
    }

    public class Warning
    {
        public string warningMessage { get; set; }
    }
    public class Error
    {
        public string errorCode { get; set; }
        public string errorMessage { get; set; }

    }
}