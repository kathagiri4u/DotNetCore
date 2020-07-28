using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq{

    public class MQ{

       public IEnumerable<string> QueryMethod1(ref int[] ints)
        {
            var intsToStrings = from i in ints
                                where i < 4
                                select i.ToString();

            return intsToStrings;
        }
        public void QueryMethod2(ref int[] ints, out IEnumerable<string> returnQ)
        {
            var intsToStrings = from i in ints
                                where i > 4
                                select i.ToString();

            returnQ = intsToStrings;
        }

    }
}

