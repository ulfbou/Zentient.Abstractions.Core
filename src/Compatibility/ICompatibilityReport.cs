// <copyright file="ICompatibilityReport.cs" authors="Zentient Framework Team">
// Copyright © 2025 Zentient Framework Team. All rights reserved.
// </copyright>

namespace Zentient.Core.Compatibility
{
    using System.Collections.Generic;
    using Zentient.Core;

    /// <summary>
    /// Report of compatibility analysis containing collected issues and an overall compatibility verdict.
    /// </summary>
    /// <remarks>
    /// Consumers should inspect <see cref="Issues"/> to determine remediation steps. Implementations
    /// should keep this object lightweight and serializable for automation and telemetry.
    /// </remarks>
    public interface ICompatibilityReport : IConcept
    {
        /// <summary>
        /// Gets a value indicating whether the analyzed specifications are considered compatible.
        /// </summary>
        bool IsCompatible { get; }

        /// <summary>
        /// Collection of discovered compatibility issues. The collection is read-only.
        /// </summary>
        IReadOnlyCollection<ICompatibilityIssue> Issues { get; }
    }
}