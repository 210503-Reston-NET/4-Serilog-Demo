## Simple Serilog C# Project Demo

# Building
Either use makefile or run:
```
cd SerilogDemo
dotnet run
```
### Makefile commands
Making dotnet commands easy. No more --project arguments or file paths.
- `make build`
    - Exectues: `dotnet build`
- `make run`
    - executes `dotnet run`
- `make test`
    - executes `detnet test`
- `make clean`
    - executes `dotnet clean`
- `make clearlogs`
    - deletes log files
