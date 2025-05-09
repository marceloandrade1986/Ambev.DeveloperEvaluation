﻿using Ambev.DeveloperEvaluation.Common.Validation;
using System.Security.Principal;

namespace Ambev.DeveloperEvaluation.Domain.Interfaces
{
    public interface IProduct 
    {
        Guid ProductId { get; }
        string Name { get; }
        string? Description { get; }
        decimal UnitPrice { get; }
        DateTime CreatedAt { get; }
        ValidationResultDetail Validate();
    }
}
