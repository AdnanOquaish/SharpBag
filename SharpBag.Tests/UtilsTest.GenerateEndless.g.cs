// <copyright file="UtilsTest.GenerateEndless.g.cs" company="SuprDewd">Copyright � SuprDewd 2010</copyright>
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
using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Pex.Framework.Generated;
using Microsoft.Pex.Engine.Exceptions;

namespace SharpBag
{
    public partial class UtilsTest
    {
[TestMethod]
[PexGeneratedBy(typeof(UtilsTest))]
public void GenerateEndless277()
{
    IEnumerable<int> iEnumerable;
    iEnumerable = this.GenerateEndless<int>(PexChoose.CreateDelegate<Func<int>>());
    Assert.IsNotNull((object)iEnumerable);
}
[TestMethod]
[PexGeneratedBy(typeof(UtilsTest))]
[PexRaisedContractException(PexExceptionState.Expected)]
public void GenerateEndlessThrowsContractException760()
{
    try
    {
      IEnumerable<int> iEnumerable;
      iEnumerable = this.GenerateEndless<int>((Func<int>)null);
      throw 
        new AssertFailedException("expected an exception of type ContractException");
    }
    catch(Exception ex)
    {
      if (!PexContract.IsContractException(ex))
        throw ex;
    }
}
[TestMethod]
[PexGeneratedBy(typeof(UtilsTest))]
public void Generate602()
{
    IEnumerable<object> iEnumerable;
    iEnumerable = this.Generate<object>(PexChoose.CreateDelegate<Func<object>>());
    Assert.IsNotNull((object)iEnumerable);
}
[TestMethod]
[PexGeneratedBy(typeof(UtilsTest))]
[PexRaisedContractException(PexExceptionState.Expected)]
public void GenerateThrowsContractException133()
{
    try
    {
      IEnumerable<object> iEnumerable;
      iEnumerable = this.Generate<object>((Func<object>)null);
      throw 
        new AssertFailedException("expected an exception of type ContractException");
    }
    catch(Exception ex)
    {
      if (!PexContract.IsContractException(ex))
        throw ex;
    }
}
    }
}