﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Draw.Elements.Type;
using ManyWho.Flow.SDK.Draw.Elements.Shared;

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

namespace ManyWho.Flow.SDK.Draw.Elements.UI
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class PageComponentAPI
    {
        [DataMember]
        public String id
        {
            get;
            set;
        }

        [DataMember]
        public Boolean isEditable
        {
            get;
            set;
        }

        [DataMember]
        public SharedElementIdAPI dataSharedElement
        {
            get;
            set;
        }

        /// <summary>
        /// Used to get the data in real-time from the external data source - using this object data request as the configuration of that
        /// request.
        /// </summary>
        [DataMember]
        public ObjectDataRequestConfigAPI objectDataRequest
        {
            get;
            set;
        }

        [DataMember]
        public String pageContainerId
        {
            get;
            set;
        }

        [DataMember]
        public String pageContainerDeveloperName
        {
            get;
            set;
        }

        /// <summary>
        /// We have a developer name field solely for external services - so they can match fields appropriately with respect
        /// to form layouts for types.
        /// </summary>
        [DataMember]
        public String developerName
        {
            get;
            set;
        }

        [DataMember]
        public String componentType
        {
            get;
            set;
        }

        [DataMember]
        public String content
        {
            get;
            set;
        }

        [DataMember]
        public String label
        {
            get;
            set;
        }

        [DataMember]
        public List<PageComponentColumnAPI> columns
        {
            get;
            set;
        }

        [DataMember]
        public SharedElementIdAPI valueBindingSharedElement
        {
            get;
            set;
        }

        [DataMember]
        public Int32 size
        {
            get;
            set;
        }

        [DataMember]
        public Int32 maxSize
        {
            get;
            set;
        }

        [DataMember]
        public Int32 height
        {
            get;
            set;
        }

        [DataMember]
        public Int32 width
        {
            get;
            set;
        }

        [DataMember]
        public Boolean required
        {
            get;
            set;
        }

        [DataMember]
        public Boolean isMultiSelect
        {
            get;
            set;
        }

        [DataMember]
        public String hintValue
        {
            get;
            set;
        }

        [DataMember]
        public String helpInfo
        {
            get;
            set;
        }

        [DataMember]
        public Int32 order
        {
            get;
            set;
        }

        [DataMember]
        public List<PageTagAPI> tags
        {
            get;
            set;
        }
    }
}
