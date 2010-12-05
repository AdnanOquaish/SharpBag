// <copyright file="UtilsTest.ExecutionTime01.g.cs" company="SuprDewd">Copyright � SuprDewd 2010</copyright>
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
using System.Diagnostics;
using Microsoft.Pex.Engine.Exceptions;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SharpBag
{
    public partial class UtilsTest
    {
        [TestMethod]
        [PexGeneratedBy(typeof(UtilsTest))]
        [PexRaisedContractException(PexExceptionState.Expected)]
        public void ExecutionTime01ThrowsContractException820()
        {
            try
            {
                int i;
                i = this.ExecutionTime01<int>
                        (PexChoose.CreateDelegate<Action>(), (Func<Stopwatch, int>)null, false);
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
        [PexGeneratedBy(typeof(UtilsTest))]
        [PexRaisedContractException(PexExceptionState.Expected)]
        public void ExecutionTime01ThrowsContractException363()
        {
            try
            {
                int i;
                i = this.ExecutionTime01<int>((Action)null, (Func<Stopwatch, int>)null, false);
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
        [PexGeneratedBy(typeof(UtilsTest))]
        [PexRaisedContractException(PexExceptionState.Expected)]
        public void ExecutionTimeThrowsContractException15()
        {
            try
            {
                long l;
                l = this.ExecutionTime((Action)null, false);
                throw
                  new AssertFailedException("expected an exception of type ContractException");
            }
            catch (Exception ex)
            {
                if (!PexContract.IsContractException(ex))
                    throw ex;
            }
        }
    }
}