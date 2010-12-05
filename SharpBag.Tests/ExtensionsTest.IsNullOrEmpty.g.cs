// <copyright file="ExtensionsTest.IsNullOrEmpty.g.cs" company="SuprDewd">Copyright � SuprDewd 2010</copyright>
// <auto-generated>
// This file contains automatically generated unit tests.
// Do NOT modify this file manually.
// 
// When Pex is invoked again,
// it might remove or update any previously generated unit tests.
// 
// If the contents of this file becomes outdated, e.g. if it does not
// compile anymore, you may delete this file and invoke Pex again.
// </auto-generated>
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Pex.Framework.Generated;

namespace SharpBag
{
    public partial class ExtensionsTest
    {
[TestMethod]
[PexGeneratedBy(typeof(ExtensionsTest))]
public void IsNullOrEmpty177()
{
    bool b;
    int[] ints = new int[0];
    b = this.IsNullOrEmpty<int>((IEnumerable<int>)ints);
    Assert.AreEqual<bool>(true, b);
}
[TestMethod]
[PexGeneratedBy(typeof(ExtensionsTest))]
public void IsNullOrEmpty839()
{
    bool b;
    int[] ints = new int[1];
    b = this.IsNullOrEmpty<int>((IEnumerable<int>)ints);
    Assert.AreEqual<bool>(false, b);
}
[TestMethod]
[PexGeneratedBy(typeof(ExtensionsTest))]
public void IsNullOrEmpty963()
{
    bool b;
    b = this.IsNullOrEmpty<int>((IEnumerable<int>)null);
    Assert.AreEqual<bool>(true, b);
}
    }
}