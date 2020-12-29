ARG FRAMEWORK
FROM mcr.microsoft.com/dotnet/runtime:${FRAMEWORK}

RUN mkdir -p /opt/ef-migrate
COPY . /opt/ef-migrate/

RUN useradd -d /opt/ef-migrate -M -r -s /usr/sbin/nologin -U ef-migrate
USER ef-migrate

ENTRYPOINT [ "dotnet", "/opt/ef-migrate/EFMigrate.dll" ]
