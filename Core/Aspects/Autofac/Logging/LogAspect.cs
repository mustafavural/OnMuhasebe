using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Logging;
using Core.CrossCuttingConcerns.Logging.Log4Net;
using Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using Core.Utilities.Interceptors.Autofac;
using Core.Utilities.Messages;
using System;
using System.Collections.Generic;

namespace Core.Aspects.Autofac.Logging
{
    public class LogAspect : MethodInterception
    {
        private LoggerServiceBase _loggerServiceBase;
        public LogAspect()
        {
            //TODO:koda config dosyası ile dışardan ayarlat...
            Type loggerService = typeof(DatabaseLogger);
            if (loggerService.BaseType != typeof(LoggerServiceBase))
            {
                throw new System.Exception(AspectMessages.WrongLoggerType);
            }
            _loggerServiceBase = (LoggerServiceBase)Activator.CreateInstance(loggerService);

        }

        protected override void OnBefore(IInvocation invocation)
        {
            _loggerServiceBase.Info(GetLogDetail(invocation));
        }

        protected override void OnException(IInvocation invocation, System.Exception e)
        {
            LogDetailWithException logDetailWithException = GetLogDetailWithException(invocation);
            logDetailWithException.ExceptionMessage = e.Message;
            _loggerServiceBase.Error(logDetailWithException);
        }

        private List<LogParameter> GetLogParameters(IInvocation invocation)
        {
            var logParameters = new List<LogParameter>();
            for (int i = 0; i < invocation.Arguments.Length; i++)
            {
                logParameters.Add(new LogParameter
                {
                    Name = invocation.GetConcreteMethod().GetParameters()[i].Name,
                    Value = invocation.Arguments[i],
                    Type = invocation.Arguments[i].GetType().Name,
                    DateTime = DateTime.Now
                });
            }
            return logParameters;
        }

        private LogDetail GetLogDetail(IInvocation invocation)
        {
            return new LogDetail
            {
                MethodName = invocation.Method.Name,
                LogParameters = GetLogParameters(invocation)
            };
        }

        private LogDetailWithException GetLogDetailWithException(IInvocation invocation)
        {
            return new LogDetailWithException
            {
                MethodName = invocation.Method.Name,
                LogParameters = GetLogParameters(invocation)
            };
        }
    }
}