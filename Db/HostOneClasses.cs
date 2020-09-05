namespace MyDbApp
{
    public class HOneCore : BaseCore<HOneSubOne, HOOneSubTwo>
    {
        public HostOne Host { get; set; }
    }

    public class HOOneSubTwo : BaseSubTwo, IHasHost<HOneCore>
    {
        public HOneCore Host { get; set; }
    }

    public class HOneSubOne : BaseSubOne, IHasHost<HOneCore>
    {
        public HOneCore Host { get; set; }
    }
}