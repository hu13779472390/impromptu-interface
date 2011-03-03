﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ImpromptuInterface;


namespace UnitTestImpromptuInterface
{
#if !SILVERLIGHT

    using NUnit.Framework;
    [SetUpFixture]
    public class FixtureSetup
    {
        private IDisposable Builder;
        
        [SetUp]
        public void Setup()
        {
            Builder = BuildProxy.WriteOutDll("ImpromptuEmit");
        }
        [TearDown]
        public void TearDown()
        {
            Builder.Dispose();
        }
    }
#endif
}
