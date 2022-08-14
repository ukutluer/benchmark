using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using BenchmarkDotNet.Attributes;

namespace HttpRequest
{
    [MemoryDiagnoser()]
    public class BenchmarkTest
    {
        private static HttpClientHandler clientHandler = new HttpClientHandler()
        {
            ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; }
        };
        private static HttpClient _httpClient = new HttpClient(clientHandler);
        
        private readonly string formattedEndpoint = "http://localhost:{0}/greetings/{1}";
        private readonly List<string> greetingNames = new List<string>() { "ugur", "john", "doe", "test" };

        [Benchmark]
        public  void GetGoResult()
        {
            foreach (var name in greetingNames)
            {
                var response = _httpClient.PostAsync(string.Format(formattedEndpoint,"6000",name),new StringContent(string.Empty, Encoding.UTF8, "application/json")).Result;
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    Console.WriteLine(string.Concat("GetGoResult  failed ---> ", response.StatusCode));    
                }
            }
        }
        
        [Benchmark]
        public  void GetSpringBootResult()
        {
            foreach (var name in greetingNames)
            {
                var response = _httpClient.PostAsync(string.Format(formattedEndpoint,"4000",name),new StringContent(string.Empty, Encoding.UTF8, "application/json")).Result;
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    Console.WriteLine(string.Concat("GetSpringBootResult  failed ---> ", response.StatusCode));    
                }
            }
        }

        
        [Benchmark]
        public  void GetNodeJsResult()
        {
            foreach (var name in greetingNames)
            {
                var response = _httpClient.PostAsync(string.Format(formattedEndpoint,"3000",name),new StringContent(string.Empty, Encoding.UTF8, "application/json")).Result;
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    Console.WriteLine(string.Concat("GetNodeJsResult  failed ---> ", response.StatusCode));    
                }
            }
        }

        
        [Benchmark(Baseline = true)]
        public  void GetNetCoreResult()
        {
            foreach (var name in greetingNames)
            {
                var response = _httpClient.PostAsync(string.Format(formattedEndpoint,"5000",name),new StringContent(string.Empty, Encoding.UTF8, "application/json")).Result;
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    Console.WriteLine(string.Concat("GetNetCoreResult  failed ---> ", response.StatusCode));    
                }
            }
        }
    }
}