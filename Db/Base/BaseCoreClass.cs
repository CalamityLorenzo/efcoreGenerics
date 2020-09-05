using System.Collections.Generic;

namespace MyDbApp
{
    public abstract class BaseCore<SubOne, SubTwo>
        where SubOne : BaseSubOne
        where SubTwo : BaseSubTwo
    {
        public int Id { get; set; }
        public int HostId { get; set; }
        public string Name { get; set; }
        public ICollection<SubOne> SubsOne {get;set;}
        public ICollection<SubTwo> SubsTwo {get;set;}
    }
}