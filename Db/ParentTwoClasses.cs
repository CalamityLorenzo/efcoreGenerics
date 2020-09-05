namespace MyDbApp
{
    public class P2Core : BaseCore<P2Sub2, P2SubOne>
    {
        public ParentTwo Host { get; set; }
    }

    public class P2Sub2 : BaseSubOne
    {
        public P2Core Host { get; set; }
    }

    public class P2SubOne : BaseSubTwo
    {
        public P2Core Host { get; set; }
    }
}