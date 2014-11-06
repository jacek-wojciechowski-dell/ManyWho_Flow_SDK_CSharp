﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Run.State;
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

namespace ManyWho.Flow.SDK.Run.Elements.Map
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class VoteRequestAPI
    {
        /// <summary>
        /// The configuration information needed for the service to function.
        /// </summary>
        [DataMember]
        public List<EngineValueAPI> configurationValues
        {
            get;
            set;
        }

        /// <summary>
        /// The authorization context the message is running within. If we're running identity with the same service, this will tell the user
        /// which users are currently authorized. The purpose of this property is to help with notifications - not to restrict access - that is
        /// managed by the ManyWho engine.
        /// </summary>
        [DataMember]
        public GroupAuthorizationAPI authorization
        {
            get;
            set;
        }

        /// <summary>
        /// The current list of votes that have been cast by end users.
        /// </summary>
        [DataMember]
        public List<UserVoteAPI> userVotes
        {
            get;
            set;
        }

        [DataMember]
        public String voteType
        {
            get;
            set;
        }

        [DataMember]
        public Int32 minimumVoters
        {
            get;
            set;
        }

        [DataMember]
        public Int32 minimumPercentage
        {
            get;
            set;
        }

        [DataMember]
        public Dictionary<String, String> attributes
        {
            get;
            set;
        }
    }
}