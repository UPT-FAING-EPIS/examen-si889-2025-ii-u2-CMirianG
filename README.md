# Examen - Pregunta 3 (Patrón Visitor)

Este repositorio incluye una implementación en C# utilizando el patrón Visitor para los tipos `Employee`, `Developer` y `Manager`, además de pruebas unitarias con xUnit y una automatización de CI con GitHub Actions.

## Estructura

- `src/EmployeeApp`: Biblioteca de clases con el modelo y el Visitor.
- `tests/EmployeeApp.Tests`: Pruebas unitarias xUnit refactorizadas al patrón Visitor.
- `.github/workflows/dotnet.yml`: Automatización para compilar y ejecutar pruebas en cada push/PR.

## Requisitos

- .NET 8 SDK instalado.

## Cómo ejecutar localmente

Desde la raíz del repositorio:

```bash
dotnet restore
dotnet build -c Release
dotnet test tests/EmployeeApp.Tests/EmployeeApp.Tests.csproj -c Release
```

## Automatización (CI)

Al hacer push o abrir un PR hacia `main`, GitHub Actions ejecutará automáticamente `dotnet restore`, `build` y `test` usando el workflow en `.github/workflows/dotnet.yml`.

## Notas

- El patrón Visitor se implementa con una interfaz genérica `IEmployeeVisitor<T>` y un método `Accept<T>` en `Employee`.
- `ReportVisitor` produce exactamente los mismos reportes que las pruebas originales esperan.

