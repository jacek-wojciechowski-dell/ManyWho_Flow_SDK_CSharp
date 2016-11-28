using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Tenant
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class FlowSettingsAPI
    {
        [DataMember]
        public bool? ScopeToState
        {
            get;
            set;
        }

        [DataMember]
        public string TimezoneOffset
        {
            get;
            set;
        }
    }
}
