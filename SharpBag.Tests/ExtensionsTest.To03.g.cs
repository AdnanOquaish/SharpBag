// <copyright file="ExtensionsTest.To03.g.cs" company="SuprDewd">Copyright � SuprDewd 2010</copyright>
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
using System.Numerics;
using Microsoft.Pex.Engine.Exceptions;
using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SharpBag
{
    public partial class ExtensionsTest
    {
#if DOTNET4
        [TestMethod]
        [PexGeneratedBy(typeof(ExtensionsTest))]
        [PexRaisedContractException(PexExceptionState.Expected)]
        public void To03ThrowsContractException968()
        {
            try
            {
                IEnumerable<BigInteger> iEnumerable;
                iEnumerable =
                  this.To03(default(BigInteger), default(BigInteger), default(BigInteger));
                throw
                  new AssertFailedException("expected an exception of type ContractException");
            }
            catch (Exception ex)
            {
                if (!PexContract.IsContractException(ex))
                    throw ex;
            }
        }
#endif
    }
}