namespace MyDbApp
{
    public class P1Core : BaseCore<P1Sub1, P1Sub2>
    {
        public ParentOne Host { get; set; }
    }

    public class P1Sub2 : BaseSubTwo, IHasHost<P1Core>
    {
        public P1Core Host { get; set; }
    }

    public class P1Sub1 : BaseSubOne, IHasHost<P1Core>
    {
        public P1Core Host { get; set; }
    }
}