// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright � ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Reflection.Test
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class System_Object_GetCustomAttributeByName_CustomAttribute : Attribute
    {
        public string Text;

        public System_Object_GetCustomAttributeByName_CustomAttribute(string text)
        {
            Text = text;
        }
    }

    [System_Object_GetCustomAttributeByName_Custom("Test Class")]
    public class System_Object_GetCustomAttributeByName_TestClass
    {
    }

    public enum System_Object_GetCustomAttributeByName_TestEnum
    {
        [System_Object_GetCustomAttributeByName_Custom("Test Enum")] Test
    }

    [TestClass]
    public class System_Object_GetCustomAttributeByName
    {
        /// <summary>
        ///     System.String GetCustomAttributeDescription(System.Object)
        /// </summary>
        [TestMethod]
        public void GetCustomAttributeByName()
        {
            // Type
            var @thisClass = new System_Object_GetCustomAttributeByName_TestClass();
            var @thisEnum = System_Object_GetCustomAttributeByName_TestEnum.Test;

            // Exemples
            var result1 = @thisClass.GetCustomAttributeByName("System_Object_GetCustomAttributeByName_CustomAttribute");
            var result2 = @thisClass.GetCustomAttributeByName("System_Object_GetCustomAttributeByName_CustomAttribute", false);
            var result3 = @thisClass.GetType().GetCustomAttributeByName("System_Object_GetCustomAttributeByName_CustomAttribute");
            var result4 = @thisClass.GetType().GetCustomAttributeByName("System_Object_GetCustomAttributeByName_CustomAttribute", false);
            var result5 = @thisEnum.GetCustomAttributeByName("System_Object_GetCustomAttributeByName_CustomAttribute");
            var result6 = @thisEnum.GetCustomAttributeByName("System_Object_GetCustomAttributeByName_CustomAttribute", false);

            // Unit Test
            Assert.AreEqual("Test Class", ((System_Object_GetCustomAttributeByName_CustomAttribute) result1).Text);
            Assert.AreEqual("Test Class", ((System_Object_GetCustomAttributeByName_CustomAttribute) result2).Text);
            Assert.AreEqual("Test Class", ((System_Object_GetCustomAttributeByName_CustomAttribute) result3).Text);
            Assert.AreEqual("Test Class", ((System_Object_GetCustomAttributeByName_CustomAttribute) result4).Text);
            Assert.AreEqual("Test Enum", ((System_Object_GetCustomAttributeByName_CustomAttribute) result5).Text);
            Assert.AreEqual("Test Enum", ((System_Object_GetCustomAttributeByName_CustomAttribute) result6).Text);
        }
    }
}