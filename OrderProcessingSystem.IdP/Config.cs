﻿using System;
using System.Collections.Generic;
using System.Security.Claims;
using IdentityServer4.Models;
using IdentityServer4.Test;

namespace OrderProcessingSystem.IdP
{
    /// <summary>
    ///     Stores Configurations
    /// </summary>
    public static class Config
    {
        /// <summary>
        ///     Test users for debugging purpose
        /// </summary>
        /// <returns>List of Users</returns>
        public static List<TestUser> GetUsers()
        {
            return new List<TestUser>
            {
                new TestUser
                {
                    SubjectId = Guid.NewGuid().ToString(),
                    Username = "Admin",
                    Password = "admin",
                    Claims = new List<Claim>
                    {
                        new Claim("given_name", "Abhishek"),
                        new Claim("family_name", "Goenka")
                    }
                }
            };
        }

        /// <summary>
        ///     Get Identity Resources
        /// </summary>
        /// <returns>List of IdentityResources</returns>
        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile()
            };
        }

        /// <summary>
        ///     Get Clients
        /// </summary>
        /// <returns>List of Clients</returns>
        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>();
        }
    }
}