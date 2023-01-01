namespace WebApplication1.Services
{
    public class GetTimeService
    {
        public string GetTime() => DateTime.Now.ToShortDateString();
    }
}
