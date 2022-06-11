## Scaffolding

### Database
~~~sh
dotnet ef migrations add --project App.DAL.EntityFramework --startup-project WebApp --context AppDbContext Initial

dotnet ef migrations remove --project App.DAL.EntityFramework --startup-project WebApp --context AppDbContext 

dotnet ef database update --project App.DAL.EntityFramework --startup-project WebApp

dotnet ef database drop --project App.DAL.EntityFramework --startup-project WebApp
~~~

### Controllers

NB! Change the slash ("/") in "-outDir Areas/Admin/Controllers" according to your operations system - its "\" on windows and "/" on *nix.

#### MVC razor based
~~~sh
cd WebApp
dotnet aspnet-codegenerator controller -name ExamplesController       -actions -m  App.Domain.Example    -dc AppDbContext -outDir Areas/Admin/Controllers --useDefaultLayout --useAsyncActions --referenceScriptLibraries -f

~~~

#### WebApi

~~~sh
cd WebApp
dotnet aspnet-codegenerator controller -name ExamplesController     -m App.Domain.Example     -actions -dc AppDbContext -outDir ApiControllers -api --useAsyncActions  -f
~~~


#### Identity pages
~~~sh
dotnet aspnet-codegenerator identity -dc App.DAL.EntityFramework.AppDbContext -f
~~~

## DOCKER

MS SQL, works on ARM also.

~~~yml
services:
  mssql-eventor2:
    container_name: "mssql-eventor2"
    image: mcr.microsoft.com/azure-sql-edge:latest
    volumes:
      - mssql-eventor2-volume:/var/opt/mssql
    restart: on-failure
    environment:
      TZ: "Europe/Tallinn"
      ACCEPT_EULA: "Y"
      # regular sql server
      SA_PASSWORD: "Bad.Pass.1"
      # sql edge
      MSSQL_SA_PASSWORD: "Bad.Pass.1"
      MSSQL_PID: Developer
    ports:
      # this maps external:internal, but the docker created network between images is connected directly - using the original ports
      # so use external for connecting with admin tools - docker will forward connection to internal port
      - "1502:1433"
~~~

Postgres

~~~yml
version: '3.8'

services:
  postgres:
    container_name: SOME_NAME
    image: postgres:latest
    restart: unless-stopped
    environment:
      - POSTGRES_USER=YOUR_USER
      - POSTGRES_PASSWORD=YOUR_PASS
    logging:
      options:
        max-size: 10m
        max-file: "3"
    ports:
      - "5444:5432"
    volumes:
      - SELECTED_NAME-postgres-volume:/var/lib/postgresql/data

volumes:
  SELECTED_NAME-postgres-volume:

~~~
