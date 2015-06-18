﻿using System;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Translate;

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

namespace ManyWho.Flow.SDK.Run
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class EngineNavigationRequestAPI
    {
        [DataMember]
        public CultureAPI culture
        {
            get;
            set;
        }

        [DataMember]
        public String stateId
        {
            get;
            set;
        }

        [DataMember]
        public String stateToken
        {
            get;
            set;
        }

        [DataMember]
        public String navigationElementId
        {
            get;
            set;
        }
    }
}
