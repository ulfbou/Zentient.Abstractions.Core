// <copyright file="IHasRelations.cs" authors="Zentient Framework Team">
// Copyright © 2025 Zentient Framework Team. All rights reserved.
// </copyright>

namespace Zentient.Core
{
    /// <summary>
    /// Defines an entity that exposes one or more relations to other concepts.
    /// </summary>
    public interface IHasRelations
    {
        /// <summary>
        /// Gets the collection of relations associated with this entity.
        /// </summary>
        IEnumerable<IRelationConcept> Relations { get; }
    }
}
