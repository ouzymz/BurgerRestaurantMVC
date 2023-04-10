# Burger Restaurant Web App 

## 1) Description

Our web app which is prepared as homework, is built on the latest version of ASP.NET Core 6.0 using the Model-View-Controller (MVC) design pattern. This powerful combination allows us to create a robust and scalable web app that is easy to maintain and update.
With the MVC pattern, our app separates the application logic into three distinct components: the model, which represents the data and business logic, the view, which presents the data to the user in an easy-to-understand format, and the controller, which handles user input and updates the model and view accordingly.

## 2) Packages That Use In The Project

- Microsoft.EntityFrameworkCore(6.0.15)
- Microsoft.EntityFrameworkCore.SqlServer(6.0.15)
- Microsoft.EntityFrameworkCore.Tools(6.0.15)
- FluentValidation.AspNetCore (11.3.0)
- AutoMapper (12.0.1)
- AutoMapper.Extensions.Microsoft.DependencyInjection (12.0.0)
- Microsoft.AspNetCore.Identity.EntityFrameworkCore (6.0.15)
- Microsoft.AspNetCore.Authentication.Facebook  (6.0.15)
- Microsoft.AspNetCore.Authentication.Google (6.0.15)

## 3) Project Path

- Entities to be used in the application are defined in the model folder.
- Fluent API is used for mapping of entities.
- Context created. Database connection is provided with Dependency Injection.
- Database was created with migration operations.
- Methods for database operations were written using the Repository Design Pattern.
- View models were created to be used in controllers.
- Data Annotation and Fluent Validation were used for the validation of the view models.
- Objects to be used in the controller (such as Repositories and mappers) were created in accordance with IoC/DI container principles.
- AutoMapper is used to map View Models and Entities.
- View pages were created using Boostrap.

