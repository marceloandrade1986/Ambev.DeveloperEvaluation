using Ambev.DeveloperEvaluation.Common.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Common.Security
{
    public interface IBranch
    {
        Guid BranchId { get; }
        string Name { get; }
        string Location { get; }
        DateTime CreatedAt { get; }

        ValidationResultDetail Validate();
    }
}
