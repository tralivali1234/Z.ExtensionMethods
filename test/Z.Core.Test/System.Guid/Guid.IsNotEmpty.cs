// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Guid_IsNotEmpty
    {
        [TestMethod]
        public void IsNotEmpty()
        {
            // Type
            Guid guidEmpty = Guid.Empty;
            Guid guidValue = Guid.NewGuid();

            // Unit Test
            Assert.IsFalse(guidEmpty.IsNotEmpty());
            Assert.IsTrue(guidValue.IsNotEmpty());
        }
    }
}