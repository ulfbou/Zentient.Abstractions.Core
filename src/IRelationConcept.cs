// <copyright file="IRelationConcept.cs" authors="Zentient Framework Team">
// Copyright © 2025 Zentient Framework Team. All rights reserved.
// </copyright>

namespace Zentient.Core
{
    /// <summary>
    /// Represents a relation between two concepts.
    /// A relation itself is a concept and can be extended with metadata, categories,
    /// or temporal information by higher-level packages.
    /// </summary>
    public interface IRelationConcept : IConcept
    {
        /// <summary>
        /// Gets the source concept of this relation.
        /// </summary>
        IConcept Source { get; }

        /// <summary>
        /// Gets the target concept of this relation.
        /// </summary>
        IConcept Target { get; }

        /// <summary>
        /// Gets the predicate identifier representing the type or meaning of this relation.
        /// Typically a lexeme or IRI-like token.
        /// </summary>
        string Predicate { get; }
    }
}
