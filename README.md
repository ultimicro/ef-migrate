# EF Migrate
[![Docker Pulls](https://img.shields.io/docker/pulls/ultimaweapon/ef-migrate)](https://hub.docker.com/r/ultimaweapon/ef-migrate)

This is a utility to run Entity Framework Core migrations that stored inside a published assembly. The only requirements is the published assembly must have a public implementation of `IDesignTimeDbContextFactory`.

## Usage

Just execute `src/EFMigrate` project with the first argument is the path to your published assembly to apply all remaining migrations.

## Limitations

The `args` argument of `CreateDbContext` is not implemented due to it will break compatibility with EF 3.1. The recommended way to pass information to the factory is environment variable.
