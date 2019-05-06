/* 
 * CyberSource Merged Spec
 *
 * All CyberSource API specs merged together. These are available at https://developer.cybersource.com/api/reference/api-reference.html
 *
 * OpenAPI spec version: 0.0.1
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

using CyberSource.Client;
using CyberSource.Api;
using CyberSource.Model;

namespace CyberSource.Test
{
    /// <summary>
    ///  Class for testing ReportsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ReportsApiTests
    {
        private ReportsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ReportsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ReportsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ReportsApi
            //Assert.IsInstanceOfType(typeof(ReportsApi), instance, "instance is a ReportsApi");
        }

        
        /// <summary>
        /// Test CreateReport
        /// </summary>
        [Test]
        public void CreateReportTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RequestBody requestBody = null;
            //string organizationId = null;
            //instance.CreateReport(requestBody, organizationId);
            
        }
        
        /// <summary>
        /// Test GetReportByReportId
        /// </summary>
        [Test]
        public void GetReportByReportIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string reportId = null;
            //string organizationId = null;
            //var response = instance.GetReportByReportId(reportId, organizationId);
            //Assert.IsInstanceOf<ReportingV3ReportsIdGet200Response> (response, "response is ReportingV3ReportsIdGet200Response");
        }
        
        /// <summary>
        /// Test SearchReports
        /// </summary>
        [Test]
        public void SearchReportsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime? startTime = null;
            //DateTime? endTime = null;
            //string timeQueryType = null;
            //string organizationId = null;
            //string reportMimeType = null;
            //string reportFrequency = null;
            //string reportName = null;
            //int? reportDefinitionId = null;
            //string reportStatus = null;
            //var response = instance.SearchReports(startTime, endTime, timeQueryType, organizationId, reportMimeType, reportFrequency, reportName, reportDefinitionId, reportStatus);
            //Assert.IsInstanceOf<ReportingV3ReportsGet200Response> (response, "response is ReportingV3ReportsGet200Response");
        }
        
    }

}
