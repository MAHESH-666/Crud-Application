# ASP.NET Web Forms CRUD Application

A classic C# ASP.NET Web Forms sample demonstrating CRUD-style data entry and display with SQL Server.

## Features

- Insert and edit records
- Display records in a GridView-style interface
- Update and delete record workflows
- SQL Server-backed sample data

## Technology

- C#
- ASP.NET Web Forms
- .NET Framework
- SQL Server
- Visual Studio / IIS Express

## Run locally

1. Open `CrudAppAspnet.sln` in Visual Studio on Windows.
2. Restore NuGet packages.
3. Inspect `Web.config` and configure a local SQL Server database and connection string.
4. Check whether the included database files are sample-only; back them up and avoid committing real personal data.
5. Run with IIS Express.

## Security and maintainability

Use parameterized SQL queries, validate all input, handle database errors, and avoid storing passwords in plain text. Do not use the included configuration as a production database setup without review.
