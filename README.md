# CarsWebAPI

Domain Driven Design - Clean Architecture


To create database using Entity Framework's code-first approach:

Step 1: Verify string connection to SQL server Database in appsettings.json

Step 2: dotnet ef migrations add InitialCreate --project CarsWebAPI 

  Note: 
    In Program.cs file for the DI we need to add where is the target for migrations assebly:
    
    // Configure services and DbContext
    builder.Services.AddDbContext<CarsDbContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly("CarsWebAPI")));
    
  The reason for this is because We have the Infrastructure and Domain in separate library projects


Step 3: dotnet ef database update --project CarsWebAPI


Project Structure:

CarsWebAPI/
│
├── Domain/
│   ├── Entities/
│   │   ├── Car.cs
│   │   └── Buyer.cs
│   ├── Repositories/
│   │   └── ICarRepository.cs
│   ├── Services/
│   │   └── ICarService.cs
│   └── ...
│
├── Application/
│   ├── Services/
│   │   └── CarService.cs
│   ├── DTOs/
│   │   ├── CarDTO.cs
│   │   └── BuyerDTO.cs
│   └── ...
│
├── Infrastructure/
│   ├── DataAccess/
│   │   └── CarRepository.cs
│   ├── ExternalServices/
│   │   └── ...
│   └── ...
│
├── Presentation/
│   ├── Controllers/
│   │   └── CarController.cs
│   └── ...
│
└── CarsWebAPI.sln
