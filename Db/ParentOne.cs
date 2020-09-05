namespace MyDbApp
{
    using System;
    using System.Collections.Generic;

    public class ParentOne : IDbParentFields, IDbIntId
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public string SameSame { get; set; }
        public DateTime Selfish { get; set; }
        public DateTime NoTime { get; set; }
        public ICollection<P1Core> CoreCollection { get; set; }
    }

}
