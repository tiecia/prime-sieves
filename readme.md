# Sieve of Atkin &  Sieve of Eratosthenes
This repository contains the code, unit tests, and performance tests for the Sieve of Atkin and Sieve of Eratosthenes.

## Project Structure
Below is a list of directories in this project and their purposes

* `./Algorithms` - contains the implementations of the two algorithms.
* `./PerformanceTests` - contains the performance tests to test the algorithms.
* `./UnitTests` - contains the unit tests that test the algorithm implementations for "correctness".

## Running the Project
To run the project you will need the [.NET 9 SDK](https://github.com/dotnet/sdk) and the `dotnet` cli too. You can either manually install these tools on your machine or use the included `direnv.nix` file to automatically setup your shell environment using the [Nix](https://nixos.org/) package manager and the [direnv](https://direnv.net/) tool.

### Unit Tests
To run the unit tests, navigate to the `./UnitTests` directory and run `dotnet test`.

### Performance Tests
To run the performance tests, navigate to the `./PerformanceTests` directory and run `dotnet run`.
