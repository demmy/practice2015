﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesLibrary.DataClasses
{
    public class SocialNetwork : IDeepCopy<SocialNetwork>
    {
        public SocialNetwork CreateDeepCopy()
        {
            SocialNetwork copy = new SocialNetwork();
            copy.Type = this.Type;
            copy.Link = this.Link;
            return copy;
        }

        public SocialNetworkType Type { get; set; }
        public string Link { get; set; }
        public SocialNetwork() { }
    }
}
