// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright � ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System.Collections.Generic;
using System.Collections.Specialized;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Collections.Test
{
    [TestClass]
    public class System_Collections_Specialized_NameValueCollection_ToDictionary
    {
        [TestMethod]
        public void ToDictionary()
        {
            // Type
            var @this = new NameValueCollection {{"Fizz", "Buzz"}};

            // Exemples
            IDictionary<string, object> result = @this.ToDictionary(); // return a Dictionary;

            // Unit Test
            Assert.AreEqual("Buzz", result["Fizz"]);
        }
    }
}