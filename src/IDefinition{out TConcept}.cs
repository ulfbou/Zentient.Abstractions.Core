// <copyright file="IDefinition2.cs" authors="Zentient Framework Team">
// Copyright © 2025 Zentient Framework Team. All rights reserved.
// </copyright>

namespace Zentient.Core
{
    /// <summary>
    /// Strongly-typed definition that binds a definition to a specific conceptual type.
    /// </summary>
    /// <typeparam name="TConcept">The concept type that this definition describes.</typeparam>
    /// <remarks>
    /// This generic definition enables type-safe associations between definitions and the
    /// conceptual types they describe. Prefer the generic form where consumers can
    /// benefit from strong typing; the non-generic <see cref="IDefinition"/> is kept
    /// for backward compatibility with existing code.
    /// </remarks>
    public interface IDefinition<out TConcept> : IDefinition
        where TConcept : IConcept
    {
        /// <summary>
        /// Gets the associated concept instance or descriptor described by this definition.
        /// </summary>
        TConcept Concept { get; }
    }
}
