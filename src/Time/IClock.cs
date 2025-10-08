// <copyright file="IClock.cs" authors="Zentient Framework Team">
// Copyright © 2025 Zentient Framework Team. All rights reserved.
// </copyright>

namespace Zentient.Core.Time
{
    using System;

    /// <summary>
    /// Deterministic clock abstraction for core.
    /// </summary>
    public interface IClock
    {
        DateTimeOffset Now { get; }
    }
}
