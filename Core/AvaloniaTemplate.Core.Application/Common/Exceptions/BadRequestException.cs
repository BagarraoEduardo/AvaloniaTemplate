using System;

namespace AvaloniaTemplate.Core.Application.Common.Exceptions;

public class BadRequestException : Exception
{
    public string[] Errors => _errors;

    private readonly string[] _errors;

    public BadRequestException(string message) : base(message)
    {
        _errors = new[] { message };
    }

    public BadRequestException(string[] errors) : base("Multiple errors occurred. See error details.")
    {
        _errors = errors;
    }

}
