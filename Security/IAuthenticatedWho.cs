﻿using System;

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

namespace ManyWho.Flow.SDK.Security
{
    public interface IAuthenticatedWho
    {
        /// <summary>
        /// The unique identifier for the user in ManyWho.
        /// </summary>
        Guid ManyWhoUserId
        {
            get;
            set;
        }

        /// <summary>
        /// The unique identifier for the tenant in ManyWho.  If logging in as a runtime user, this will be blank.  This field is only required for users
        /// logging in to build flows as it will be used for all filtering of elements.
        /// </summary>
        Guid ManyWhoTenantId
        {
            get;
            set;
        }

        /// <summary>
        /// The authentication token used by ManyWho.
        /// </summary>
        String ManyWhoToken
        {
            get;
            set;
        }

        /// <summary>
        /// The current geo location of the user making the request.  This object can be null depending on the permissions accepted by the end user.
        /// </summary>
        IGeoLocation GeoLocation
        {
            get;
            set;
        }

        /// <summary>
        /// The user identifier as provided post authentication and authorization with the service.
        /// </summary>
        String UserId
        {
            get;
            set;
        }

        /// <summary>
        /// The username provided at login with the service.
        /// </summary>
        String Username
        {
            get;
            set;
        }

        /// <summary>
        /// The identifier provider as provided post authentication and authorization with the service.
        /// </summary>
        String IdentityProvider
        {
            get;
            set;
        }

        /// <summary>
        /// The token as provided post authentication and authorization with the service.
        /// </summary>
        String Token
        {
            get;
            set;
        }

        /// <summary>
        /// The name of the tenant being logged into.
        /// </summary>
        String TenantName
        {
            get;
            set;
        }

        /// <summary>
        /// The name of the remote directory that was used to perform the login.
        /// </summary>
        String DirectoryName
        {
            get;
            set;
        }

        /// <summary>
        /// The unique identifier for the directory.
        /// </summary>
        String DirectoryId
        {
            get;
            set;
        }

        /// <summary>
        /// The name of the user role.
        /// </summary>
        String RoleName
        {
            get;
            set;
        }

        /// <summary>
        /// The unique identifier for the user role.
        /// </summary>
        String RoleId
        {
            get;
            set;
        }

        /// <summary>
        /// The name of the primary group for which this user is a member.
        /// </summary>
        String PrimaryGroupName
        {
            get;
            set;
        }

        /// <summary>
        /// The unique identifier for the primary group for which this user is a member.
        /// </summary>
        String PrimaryGroupId
        {
            get;
            set;
        }

        /// <summary>
        /// The validated email address for this user.
        /// </summary>
        String Email
        {
            get;
            set;
        }

        /// <summary>
        /// The first name for this user.
        /// </summary>
        String FirstName
        {
            get;
            set;
        }

        /// <summary>
        /// The last name for this user.
        /// </summary>
        String LastName
        {
            get;
            set;
        }
    }
}
