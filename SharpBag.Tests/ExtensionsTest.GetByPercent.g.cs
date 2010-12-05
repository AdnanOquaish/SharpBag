// <copyright file="ExtensionsTest.GetByPercent.g.cs" company="SuprDewd">Copyright � SuprDewd 2010</copyright>
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
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Pex.Framework.Generated;
using Microsoft.Pex.Engine.Exceptions;

namespace SharpBag
{
    public partial class ExtensionsTest
    {
[TestMethod]
[PexGeneratedBy(typeof(ExtensionsTest))]
[PexRaisedContractException(PexExceptionState.Expected)]
public void GetByPercentThrowsContractException730()
{
    try
    {
      int i;
      int[] ints = new int[0];
      i = this.GetByPercent<int>(ints, -1);
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
[PexGeneratedBy(typeof(ExtensionsTest))]
[PexRaisedException(typeof(IndexOutOfRangeException))]
public void GetByPercentThrowsIndexOutOfRangeException858()
{
    try
    {
        int i;
        int[] ints = new int[0];
        i = this.GetByPercent<int>(ints, 0);
        throw
          new AssertFailedException("expected an exception of type ContractException");
    }
    catch (Exception ex)
    {
        if (!PexContract.IsContractException(ex))
            throw ex;
    }
}
[TestMethod]
[PexGeneratedBy(typeof(ExtensionsTest))]
public void GetByPercent562()
{
    int i;
    int[] ints = new int[1];
    i = this.GetByPercent<int>(ints, 0);
    Assert.AreEqual<int>(0, i);
}
[TestMethod]
[PexGeneratedBy(typeof(ExtensionsTest))]
[PexRaisedContractException(PexExceptionState.Expected)]
public void GetByPercentThrowsContractException151()
{
    try
    {
      int i;
      i = this.GetByPercent<int>((int[])null, 0);
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
[PexGeneratedBy(typeof(ExtensionsTest))]
[PexRaisedContractException(PexExceptionState.Expected)]
public void GetByPercentThrowsContractException316()
{
    try
    {
      int i;
      int[] ints = new int[1];
      i = this.GetByPercent<int>(ints, -1);
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