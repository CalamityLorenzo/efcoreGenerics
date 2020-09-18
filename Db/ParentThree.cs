namespace MyDbApp
{
    public class ParentThree : IDbIntId
    {
        public int Id { get; set; }
        public int P1CoreId { get; set; }
        public string Name { get; set; }
        public P3Core P1Core { get; set; }
    }
}
