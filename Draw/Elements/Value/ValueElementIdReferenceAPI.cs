﻿using System;
using System.Runtime.Serialization;

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
    public class ValueElementIdReferenceAPI : ValueElementIdAPI
    {
        [DataMember]
        public String developerName
        {
            get;
            set;
        }

        [DataMember]
        public String typeElementDeveloperName
        {
            get;
            set;
        }

        [DataMember]
        public String typeElementPropertyDeveloperName
        {
            get;
            set;
        }

        [DataMember]
        public string typeElementEntryTypeElementDeveloperName
        {
            get;
            set;
        }

        [DataMember]
        public String typeElementPropertyTypeElementId
        {
            get;
            set;
        }

        [DataMember]
        public String elementType
        {
            get;
            set;
        }

        [DataMember]
        public String typeElementId
        {
            get;
            set;
        }

        [DataMember]
        public String serviceElementId
        {
            get;
            set;
        }

        [DataMember]
        public String serviceElementDeveloperName
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

        [DataMember]
        public String parentContentType
        {
            get;
            set;
        }

        [DataMember]
        public Boolean isFixed
        {
            get;
            set;
        }

        [DataMember]
        public string access
        {
            get;
            set;
        }
    }
}
