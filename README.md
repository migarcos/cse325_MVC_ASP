# ASP.NET Core UI: MVC
Building a ASP.NET Core UI web application using the MVC approach.


# Execution
On VSCode open a Terminal, and execute
````
dotnet run
````
Open hte browser and execute an endpoint, sample:
````
http://localhost:[PORT]/HelloWorld
````
## Set UP
The dotnet new command creates a new Razor Pages project in the RazorPagesMovie folder.
````
dotnet new webapp -o RazorPagesMovie
````
Trust the HTTPS development certificate by running the following command
````
dotnet dev-certs https --trust
````
### Util URL:
- [Get started with Razor Pages in ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-8.0&tabs=visual-studio-code)
- [Ratings list](https://www.showbizjunkies.com/mpaa-ratings/)