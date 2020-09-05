using System;
using System.Collections.Generic;

namespace MyDbApp
{
    public class ParentTwo : IDbParentFields, IDbIntId
    {
        public int Id { get; set; }
        public string PuffDaddy { get; set; }
        public string SameSame { get; set; }
        public DateTime NoTime { get; set; }
        public ICollection<P2Core> CoreCollection{get;set;}

    }
}