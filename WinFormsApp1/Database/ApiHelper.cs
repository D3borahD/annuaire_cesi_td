﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
//using System.Text;
//using System.Threading.Tasks;

namespace WinFormsApp1.Database
{
    public static class ApiHelper
    {
        public static HttpClient ApiClient { get; set; }

        // base url 
        public static string url = "http://127.0.0.1:5163/api/";

        public static void InitializeClient()
        {
            ApiClient = new HttpClient();
            ApiClient.BaseAddress = new Uri("http://127.0.0.1:5163/api/");
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
