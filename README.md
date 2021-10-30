# Animal Shelter

### By Art Weinstein

### A basic API that allows users to access a list of available animals in a shelter. Users can add, view and delete animals. 

## Technologies Used

* C#
* ASP.NET Core MVC
* NuGet
* MySql WorkBench
* Entity Framework Core
* Swagger

## Description

This API gives users access to a list of seeded data in the form of an API. Users can access this data by making calls on swagger and viewing a list of avaiable animals. Users can also post and delete data through swagger as well and test the various functionalites of the API. 

## Setup/Installation Requirements

1. [Clone](https://docs.github.com/en/github/creating-cloning-and-archiving-repositories/cloning-a-repository-from-github/cloning-a-repository) this repository.
2. Within VS code or similar software, create an "appsettings.json file within the "AnimalShelter" directory.
3. Within the appsettings.json file copy the following code and replace "EXAMPLE_PASSWORD" with your SQL workbench password.
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=art_weinstein;uid=root;pwd=EXAMPLE_PASSWORD;"
  }
}
```

4. Install the necessary dependencies:
- type ```dotnet add package Microsoft.EntityFrameworkCore -v 5.0.0```
- type ```dotnet add package Pomelo.EntityFrameworkCore.MySql -v 5.0.0-alpha.2```
- type ```dotnet add package Microsoft.EntityFrameworkCore.Proxies -v 5.0.0 ```
1. enter ```dotnet build``` in your powershell terminal to build the program and verify the code is running correctly.
2. enter ```dotnet ef database update``` to populate your database with the necessary data.
3. enter ```dotnet watch run``` to create a localhost in your browser and view the program. A localhost:5001/swagger/index.html should automatically open in your browser. If it does not, enter ```https://localhost:5001/swagger/index.html```
4. Follow the prompts on swagger to test the functionality by selecting the method you want to test, select "Try it out," and then select "execute." Data will appear under the request URL.
5. To test methods like "Post," fill in the necessary data for the animal you want to add. It is not necessary to add an AnimalId, so delete that. Your code should look like this:
   ```
   {
    "animalName": "your animal's name",
    "animalType": "your animal's type",
    "animalAge": your animal's age
   }
   ```

## Known Bugs

* No bugs known at the moment.

## License

* [MIT License](https://opensource.org/licenses/MIT)

Copyright (c) 2021 Art Weinstein

## Contact Information

[Email](artur.weintsein@gmail.com)