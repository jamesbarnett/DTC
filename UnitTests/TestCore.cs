using System;
using System.Diagnostics;
using System.IO;
using NUnit.Framework;
using Dtc.Core;

namespace UnitTests
{
    [TestFixture()]
    public class TestCore
    {
        [Test()]
        public void it_parses_catalog_json()
        {
            Catalog catalog = Catalog.Load();
            Debug.WriteLine(string.Format("Catalog: {0}", catalog));
        }
    }
}
