// <copyright file="ICompatibilityIssue.cs" authors="Zentient Framework Team">
// Copyright © 2025 Zentient Framework Team. All rights reserved.
// </copyright>

namespace Zentient.Core.Compatibility
{
    using System.Collections.Generic;
    using Zentient.Core;

    /// <summary>
    /// Describes a single compatibility issue discovered during migration analysis.
    /// </summary>
    /// <remarks>
    /// Implementations should produce clear, localized-independent messages and include a machine-readable
    /// path indicating where the issue occurred (e.g. JSON path or property name). Severity is a free-form
    /// token but common values include "Info", "Warning", and "Error".
    /// </remarks>
    public interface ICompatibilityIssue : IConcept
    {
        /// <summary>
        /// Path to the affected element (e.g. JSON path or member name).
        /// </summary>
        string Path { get; }

        /// <summary>
        /// Human-friendly message describing the issue.
        /// </summary>
        string Message { get; }

        /// <summary>
        /// Severity of the issue (Info, Warning, Error, etc.).
        /// </summary>
        string Severity { get; }

        /// <summary>
        /// Optional structured metadata providing diagnostics and remediation hints.
        /// </summary>
        IReadOnlyDictionary<string, object?> Metadata { get; }
    }
}