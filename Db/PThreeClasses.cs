using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDbApp
{
    public class P3Core : BaseCore<P3Sub1, P3Sub2>
    {
        public ParentThree Host { get; set; }
    }

    public class P3Sub2 : BaseSubTwo, IHasHost<P3Core>
    {
        public P3Core Host { get; set; }
    }

    public class P3Sub1 : BaseSubOne, IHasHost<P3Core>
    {
        public P3Core Host { get; set; }
    }
}
