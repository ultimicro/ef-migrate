# EF Migrate

This is a small command line utility for executing Entity Framework Core migrations from a published assembly.

## Usage

Your published project need to implement `IDesignTimeDbContextFactory`. You can execute `src/EFMigrate` with the first argument is the path to your published assembly to apply all remaining migrations.