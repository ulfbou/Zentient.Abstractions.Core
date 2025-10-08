# 🌱 Zentient.Abstractions.Core

Minimal, stable, async-first aligned bedrock for the Zentient framework.

> 📦 Package: `Zentient.Abstractions.Core`  
> 🧬 Version: `0.1.0`  
> 🔄 Replaces: `Zentient.Abstractions` (legacy monolith, v3.0.2)  
> 🧩 Complements: `Zentient.{FEATURE|DOMAIN}.Abstractions` packages

--- 

## ✨ What is Zentient.Abstractions.Core?

Zentient.Abstractions.Core is the foundational contract layer for the Zentient ecosystem. It defines the universal concept interfaces, governance attributes, and async-first registry patterns that power all Zentient domains—without any implementation or domain coupling.

This package is intentionally lean. It contains only what every domain needs, and nothing more.

--- 

## 🚀 Why this package?

Zentient.Abstractions 3.0.2 was a powerful but bloated monolith—spanning metadata, diagnostics, envelopes, execution, relations, and more. While expressive, it created tight coupling, slow builds, and contributor friction.

Zentient.Abstractions.Core 0.1.0 is a clean break:
- ✅ Async-first registry and builder contracts
- ✅ Strong concept modeling (IConcept, IValueObject, IIdentifiable, etc.)
- ✅ Governance attributes for analyzers (PublicContract, DeprecatedIn, StableSince)
- ✅ No implementation, no dependencies, no runtime baggage
- ✅ Designed for analyzability, testability, and DX-first onboarding

--- 

## 🧠 Architectural Shift

| Legacy (3.0.2)                          | New (Core + Modular)                          |
|----------------------------------------|-----------------------------------------------|
| One massive package                    | Core + domain-specific abstraction packages   |
| Mixed contracts and implementations    | Pure contracts only                           |
| Tight coupling across domains          | Explicit boundaries per domain                |
| Hard to onboard new contributors       | DX-first templates, analyzers, and guides     |
| Registry and builder patterns mixed    | Async-first, composable interfaces            |

The new model encourages modularity, clarity, and governance discipline. Each domain (e.g., Metadata, Diagnostics, Messaging) now owns its own `Zentient.{Domain}.Abstractions` package, built atop this core.

--- 

## 🆕 Key Interfaces in Core

- `IConcept` — Root marker for all Zentient types
- `IIdentifiable<T>` / `IIdentifiable` — Stable identity contracts
- `IValueObject` — Immutable, value-equality semantics
- `INamed`, `IDescribed`, `IVersioned` — Human-friendly metadata
- `IRegistry<T>` / `IAsyncRegistry<T>` — In-process and async-first registries
- `IBuilder<T>` / `IAsyncBuilder<T>` — Construction contracts
- `IClock` — Deterministic time abstraction
- `IConceptEqualityComparer<T>` — Analyzer-friendly equality enforcement

--- 

## 🧭 Migration Guide

To migrate from Zentient.Abstractions 3.0.2:

1. Replace `Zentient.Abstractions` with:
   - `Zentient.Abstractions.Core`
   - `Zentient.Metadata.Abstractions`, `Zentient.Diagnostics.Abstractions`, etc. as needed

2. Refactor usages of:
   - `ITypeDefinition`, `IMetadata`, `IResult`, etc. to their domain-specific packages
   - Registry and builder patterns to async-first interfaces

3. Use Roslyn analyzers (coming soon) to enforce DX-first conventions and flag legacy usage.

4. Follow migration catalogs and contributor field manuals for domain-specific guidance.

--- 

## 🧪 Compatibility

- .NET Standard 2.0+
- No runtime dependencies
- Fully analyzable and testable
- Designed for use in SDKs, analyzers, and domain modeling

--- 

## 🧰 Governance Attributes

These attributes help enforce contributor discipline and semantic clarity:

- `[PublicContract]` — Marks stable, external-facing APIs
- `[Experimental]` — Marks unstable or evolving APIs
- `[StableSince("x.y.z")]` — Declares stability version
- `[DeprecatedIn("x.y.z", ReplacedBy = "NewContract")]` — Marks deprecated contracts
- `[InternalOnly]` — Blocks external usage

--- 

## 🧩 Related Packages

| Package                             | Purpose                                      |
|------------------------------------|----------------------------------------------|
| `Zentient.Metadata.Abstractions`   | Metadata modeling and definitions            |
| `Zentient.Diagnostics.Abstractions`| Health checks, diagnostics, observability    |
| `Zentient.Envelopes.Abstractions`  | Result and error wrapping                    |
| `Zentient.Errors.Abstractions`     | Error modeling and severity contracts        |

Together, these packages form the new Zentient abstraction lattice.

--- 

## ❤️ Contributor Experience

Zentient.Abstractions.Core is designed for:
- Fast onboarding via `dotnet new` templates
- Analyzer-enforced governance
- Clear, example-driven documentation
- Modular, observable, and maintainable architecture

--- 

## 📦 Install via NuGet

```bash
dotnet add package Zentient.Abstractions.Core --version 0.1.0
```

--- 

## 🛠️ License & Source

This package is open-source and governed by the Zentient contributor field manual. See [source and documentation](https://github.com/ulfbou/Zentient.Abstractions.Core/blob/main/).
