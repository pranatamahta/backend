using Microsoft.Extensions.Diagnostics.HealthChecks;
using System;
using System.Collections.Generic;
using System.Dynamic;

namespace backend.Model
{
    public class Response
    {
        public string message { get;set; }
        public List<Object> data { get; set; }
    }
}
