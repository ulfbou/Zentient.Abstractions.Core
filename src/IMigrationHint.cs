// <copyright file="IMigrationHint.cs" authors="Zentient Framework Team">
// Copyright © 2025 Zentient Framework Team. All rights reserved.
// </copyright>

namespace Zentient.Core
{
    /// <summary>
    /// Provides a structured hint to assist migrating from one version of a concept to another.
    /// </summary>
    /// <remarks>
    /// Migration hints should be concise, actionable, and machine-readable where possible. They are
    /// intended to be surfaced to developers during upgrade tooling or in documentation.
    /// </remarks>
    public interface IMigrationHint : IConcept
    {
        /// <summary>
        /// The version of the older concept.
        /// </summary>
        string FromVersion { get; }

        /// <summary>
        /// The version of the newer concept.
        /// </summary>
        string ToVersion { get; }

        /// <summary>
        /// Human-readable suggestion describing migration steps or recommended replacements.
        /// </summary>
        string Suggestion { get; }
    }
}