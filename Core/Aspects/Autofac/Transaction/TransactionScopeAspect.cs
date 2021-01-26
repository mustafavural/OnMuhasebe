﻿using Castle.DynamicProxy;
using Core.Utilities.Interceptors.Autofac;
using System.Transactions;

namespace Core.Aspects.Autofac.Transaction
{
    public class TransactionScopeAspect : MethodInterception
    {
        public override void Intercept(IInvocation invocation)
        {
            using (TransactionScope transactionScope = new TransactionScope())
            {
                try
                {
                    invocation.Proceed();
                    transactionScope.Complete();
                }
                catch
                {
                    transactionScope.Dispose();
                    throw;
                }
            }
        }
    }
}
