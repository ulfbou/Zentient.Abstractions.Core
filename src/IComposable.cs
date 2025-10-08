// <copyright file="IComposable.cs" authors="Zentient Framework Team">
// Copyright © 2025 Zentient Framework Team. All rights reserved.
// </copyright>

namespace Zentient.Core
{
    /// <summary>
    /// Indicates that a concept is composed of multiple parts or sub-concepts.
    /// </summary>
    /// <remarks>
    /// The <see cref="Parts"/> property provides access to the constituent concepts that
    /// make up this composite concept. This can be used for hierarchical modeling,
    /// analysis, or transformation scenarios.
    /// </remarks>
    public interface IComposable
    {
        /// <summary>
        /// Gets the collection of constituent parts that compose this concept.
        /// </summary>
        IEnumerable<IConcept> Parts { get; }
    }

}
