﻿using System;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Security;

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

namespace ManyWho.Flow.SDK.Draw.Elements.Value
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class MacroElementResponseAPI : MacroElementRequestAPI
    {
        [DataMember]
        public DateTime dateCreated
        {
            get;
            set;
        }

        [DataMember]
        public DateTime dateModified
        {
            get;
            set;
        }

        [DataMember]
        public BuilderWhoAPI whoCreated
        {
            get;
            set;
        }

        [DataMember]
        public BuilderWhoAPI whoModified
        {
            get;
            set;
        }

        [DataMember]
        public BuilderWhoAPI whoOwner
        {
            get;
            set;
        }
    }
}