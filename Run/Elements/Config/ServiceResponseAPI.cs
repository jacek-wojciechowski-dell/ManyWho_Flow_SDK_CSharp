﻿using System;
using System.Collections.Generic;
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

namespace ManyWho.Flow.SDK.Run.Elements.Config
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class ServiceResponseAPI : BaseResponseAPI
    {
        /// <summary>
        /// Tells the engine what this service would like it to do.  At the moment, there are really only
        /// two possible commands: WAIT (to tell the engine to wait for a completed response) or DONE (to
        /// tell the engine that it has completed its work.
        /// </summary>
        [DataMember]
        public String invokeType
        {
            get;
            set;
        }

        /// <summary>
        /// The wait message to show the user if we're dealing with an asynchronous message.
        /// </summary>
        [DataMember]
        public String waitMessage
        {
            get;
            set;
        }

        /// <summary>
        /// The outputs from the service response.  The service can return interim output values if we're in
        /// a WAIT engine command state.
        /// </summary>
        [DataMember]
        public List<EngineValueAPI> outputs
        {
            get;
            set;
        }

        /// <summary>
        /// The outcome the service wishes to select to progress the engine. This may or may not succeed based on business rules.
        /// </summary>
        [DataMember]
        public String selectedOutcomeId
        {
            get;
            set;
        }

        /// <summary>
        /// Any general root faults that happened from making the request.
        /// </summary>
        [DataMember]
        public Dictionary<String, String> rootFaults
        {
            get;
            set;
        }

        /// <summary>
        /// The faults that occurred with the input values that were provided in the request.
        /// </summary>
        [DataMember]
        public List<ValueFaultAPI> valueFaults
        {
            get;
            set;
        }

        /// <summary>
        /// The debug mode to run the engine in.  For the service response, we do not pass the mode up into the engine as it would make it impossible to step through
        /// currently as the user won't have access (though we simply haven't tried it - it might work).
        /// </summary>
        [DataMember]
        public String mode
        {
            get;
            set;
        }
    }
}