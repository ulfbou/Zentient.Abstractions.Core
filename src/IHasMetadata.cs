// <copyright file="IHasMetadata.cs" authors="Zentient Framework Team">
// Copyright © 2025 Zentient Framework Team. All rights reserved.
// </copyright>

namespace Zentient.Core
{
    /// <summary>
    /// Marker interface for concepts that expose metadata.
    /// </summary>
    /// <remarks>
    /// Types implementing <see cref="IHasMetadata"/> indicate they provide
    /// additional metadata about the concept instance.
    /// <see cref="IHasMetadata{TMetadata}"/> is preferred when the metadata type is known.
    /// </remarks>
    public interface IHasMetadata { }
}
