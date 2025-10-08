// <copyright file="IConceptEqualityComparer{T}.cs" authors="Zentient Framework Team">
// Copyright © 2025 Zentient Framework Team. All rights reserved.
// </copyright>

namespace Zentient.Core
{
    /// <summary>
    /// Provides an equality comparer specialized for framework conceptual types.
    /// </summary>
    /// <remarks>
    /// This targeted comparer exists for rare scenarios where a concept-specific equality
    /// strategy is required. In most cases prefer using <see cref="System.Collections.Generic.IEqualityComparer{T}"/>.
    /// Consider placing custom comparers in domain-level packages to avoid expanding the core surface.
    /// </remarks>
    /// <typeparam name="T">Concept type.</typeparam>
    public interface IConceptEqualityComparer<T> : IEqualityComparer<T>
        where T : IConcept
    { }
}
