using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyWho.Flow.SDK.Run.State
{
    public class StateValueFaultAPI
    {
        public Guid valueElementId
        {
            get;
            set;
        }
        public Guid typeElementEntryId
        
        {
            get;
            set;
        }

        public String faultCode
        {
            get;
            set;
        }

        public String faultMessage
        {
            get;
            set;
        }
    }
}
