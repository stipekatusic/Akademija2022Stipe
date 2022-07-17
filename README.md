# King ICT Akademija 2022

Projekt u sklopu predavanja KING ICT Akademije - "**Backend Arhitektura Sustava**".

### Tehnologije

 - .NET5
 - MS SQL
 - Entity Framework Core (Code First)
 - FluentValidator (https://docs.fluentvalidation.net/en/latest/)
 - AutoMapper (https://automapper.org/)
 - MediatR (https://github.com/jbogard/MediatR)
 - Swagger (https://swagger.io/)

### Pokretanje projekta

**Preduvjeti:**

 - Instaliran .NET 5
 - Instaliran MS SQL Server
 
 Nakon što smo klonirali projekt potrebno je:
 
 - Provjeriti konekcijski string na bazu podataka (Api/appsettings.json)
 - Provjeriti dali se projekt uredno builda i pokreæe
 - U Visual Studiu otvoriti "Package Manager Console" i pokrenuti migracije na bazi naredbom "Update-Database"
 - Provjeriti da se kreirala baza podataka "Akademija" i da sadrži tablice "dbo._EFMigrationsHistory" i "dbo.Tests"
