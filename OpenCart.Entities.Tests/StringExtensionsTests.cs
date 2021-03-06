﻿using NUnit.Framework;
using System;

namespace OpenCart.Entities.Tests
{
    [TestFixture]
    public class StringExtensionsTests
    {        
        [TestCase("Currency", true)]
        [TestCase("currency", false)]
        [TestCase("StockStatus", true)]
        [TestCase("stockStatus", false)]
        [TestCase("stockstatus", false)]
        [TestCase("SKU", true)]
        public void ShouldDeterminePascalConvention(string value, bool inPascal)
        {
            Assert.AreEqual(Notations.InPascal(value), inPascal);
        }

        [TestCase("")]
        [TestCase(null)]
        public void ShouldThrowException(string value)
        {
            Assert.Throws<ArgumentNullException>(() => Notations.InPascal(value));
        }
    }
}
