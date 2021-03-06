﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Run.Elements.Type;

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

namespace ManyWho.Flow.SDK.Run.State
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class StateValueAPI
    {
        [DataMember]
        public String valueElementId
        {
            get;
            set;
        }

        [DataMember]
        public String valueElementDeveloperName
        {
            get;
            set;
        }

        [DataMember]
        public List<ObjectAPI> objectData
        {
            get;
            set;
        }

        [DataMember]
        public String contentValue
        {
            get;
            set;
        }

        [DataMember]
        public String contentType
        {
            get;
            set;
        }
    }
}
