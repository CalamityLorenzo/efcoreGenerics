namespace MyDbApp
{
    public class HTwoCore : BaseCore<HTwoSubOne, HTwoSubTwo>
    {
        public HostTwo Host { get; set; }
    }

    public class HTwoSubOne : BaseSubOne
    {
        public HTwoCore Host { get; set; }
    }

    public class HTwoSubTwo : BaseSubTwo
    {
        public HTwoCore Host { get; set; }
    }
}