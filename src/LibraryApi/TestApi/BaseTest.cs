using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TestApi
{
    public class BaseTest
    {
        protected HttpClient? httpClinet;

        public BaseTest()
        {
            var application = new WebApplicationFactory<Program>()
        .WithWebHostBuilder(builder =>
        {
        });

            httpClinet = application.CreateClient();
        }
    }
}