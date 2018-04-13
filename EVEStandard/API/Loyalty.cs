﻿using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace EVEStandard.API
{
    public class Loyalty : APIBase
    {
        private ILogger Logger { get; } = LibraryLogging.CreateLogger<Loyalty>();
        internal Loyalty(string dataSource) : base(dataSource)
        {
        }
    }
}