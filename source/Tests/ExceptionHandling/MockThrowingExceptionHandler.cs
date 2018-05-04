﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;
using EnterpriseLibrary.ExceptionHandling.Configuration;

namespace EnterpriseLibrary.ExceptionHandling.Tests
{
    public class MockThrowingExceptionHandler : IExceptionHandler
    {
        private const string handlerFailed = "Handler Failed";

        public MockThrowingExceptionHandler()
        {
        }

        public MockThrowingExceptionHandler(CustomHandlerData customHandlerData)
            : this()
        {        
        }

        public Exception HandleException(Exception exception, Guid correlationID)
        {
            throw new NotImplementedException(handlerFailed);
        }
    }
}

