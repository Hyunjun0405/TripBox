namespace WebAPI.Controllers
{
    public class RequstStatus
    {
        public Error error { get; set; }
        public bool success { get; set; }
        public string version { get; set; }
        public Warning warning { get; set; }
    }
}