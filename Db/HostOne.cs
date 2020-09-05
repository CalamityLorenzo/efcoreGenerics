using System;
using System.Collections.Generic;

namespace MyDbApp
{
    public class HostOne : IDbHostFields, IDbIntId
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public string SameSame { get; set; }
        public DateTime Selfish { get; set; }
        public DateTime NoTime { get; set; }
        public ICollection<HOneCore> CoreCollection{get;set;}
    }
}