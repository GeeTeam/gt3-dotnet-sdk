using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeetestSDK
{
    public class GeetestOptions : IOptions<GeetestOptions>
    {
        public string Id { get; set; }

        public string Key { get; set; }

        public GeetestOptions Value => this;
    }
}
