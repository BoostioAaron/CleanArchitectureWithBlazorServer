// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace CleanArchitecture.Blazor.Application.Common.ExceptionHandler;

public class ForbiddenException : ServerException
{
    public ForbiddenException(string message) : base(message,null,System.Net.HttpStatusCode.Forbidden) { }
}
