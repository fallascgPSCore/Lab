# LabLibrary

Una librería C# simple que imprime mensajes en consola. Diseñada para ser publicada en NuGet y consumida por otras aplicaciones.

## Características

- ✅ Clase `DummyClass` con métodos de impresión en consola
- ✅ Configurada para publicación automática en NuGet
- ✅ Compilación con GitHub Actions
- ✅ Documentación XML integrada

## Instalación

Desde NuGet Package Manager:

```bash
dotnet add package LabLibrary
```

O desde Package Manager Console:

```powershell
Install-Package LabLibrary
```

## Uso

```csharp
using LabLibrary;

var dummy = new DummyClass();
dummy.PrintGreeting("Usuario");
dummy.PrintMessage("Este es un mensaje de prueba");
Console.WriteLine(dummy.GetVersionInfo());
```

## Compilación Local

```bash
dotnet build
dotnet pack
```

## CI/CD

Este repositorio usa GitHub Actions para:
- Compilar automáticamente en cada push
- Ejecutar pruebas (cuando estén disponibles)
- Publicar el paquete en NuGet (releases)

## Requisitos

- .NET 6.0 SDK o superior

## Licencia

MIT
