// <copyright file="IAware{out TConcept}.cs" authors="Zentient Framework Team">
// Copyright © 2025 Zentient Framework Team. All rights reserved.
// </copyright>

namespace Zentient.Core
{
    /// <summary>
    /// Indicates that an entity is aware of another conceptual entity.
    /// </summary>
    /// <typeparam name="TConcept">The type of concept being referenced.</typeparam>
    /// <remarks>
    /// This interface is useful for establishing relationships between concepts
    /// without tightly coupling their implementations.
    /// </remarks>
    public interface IAware<out TConcept> where TConcept : IConcept
    {
        /// <summary>
        /// Gets the referenced concept.
        /// </summary>
        TConcept Concept { get; }
    }
}
