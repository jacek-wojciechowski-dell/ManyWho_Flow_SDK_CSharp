﻿using System;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Draw.Elements.Group;


/*!

Copyright 2013 Manywho, Inc.

Licensed under the Manywho License, Version 1.0 (the "License"); you may not use this
file except in compliance with the License.

You may obtain a copy of the License at: http://manywho.com/sharedsource

Unless required by applicable law or agreed to in writing, software distributed under
the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
KIND, either express or implied. See the License for the specific language governing
permissions and limitations under the License.

*/

namespace ManyWho.Flow.SDK.Draw.Flow
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class FlowRequestAPI
    {
        [DataMember]
        public String editingToken
        {
            get;
            set;
        }

        [DataMember]
        public FlowIdAPI id
        {
            get;
            set;
        }

        [DataMember]
        public String developerName
        {
            get;
            set;
        }

        [DataMember]
        public String developerSummary
        {
            get;
            set;
        }

        [DataMember]
        public String startMapElementId
        {
            get;
            set;
        }

        [DataMember]
        public Boolean allowJumping
        {
            get;
            set;
        }

        [DataMember]
        public int stateExpirationLength
        {
            get;
            set;
        }

        [DataMember]
        public GroupAuthorizationAPI authorization
        {
            get;
            set;
        }
    }
}