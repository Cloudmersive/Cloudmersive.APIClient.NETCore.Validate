/* 
 * validateapi
 *
 * The validation APIs help you validate data. Check if an E-mail address is real. Check if a domain is real. Check up on an IP address, and even where it is located. All this and much more is available in the validation API.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Cloudmersive.APIClient.NETCore.Validate.Client;
using Cloudmersive.APIClient.NETCore.Validate.Api;
using Cloudmersive.APIClient.NETCore.Validate.Model;

namespace Cloudmersive.APIClient.NETCore.Validate.Test
{
    /// <summary>
    ///  Class for testing VatApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class VatApiTests
    {
        private VatApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new VatApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of VatApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' VatApi
            //Assert.IsInstanceOfType(typeof(VatApi), instance, "instance is a VatApi");
        }

        
        /// <summary>
        /// Test VatVatLookup
        /// </summary>
        [Test]
        public void VatVatLookupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //VatLookupRequest input = null;
            //var response = instance.VatVatLookup(input);
            //Assert.IsInstanceOf<VatLookupResponse> (response, "response is VatLookupResponse");
        }
        
    }

}
