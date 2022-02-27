# Migration from .NET CORE2.2 to .NET CORE 3.1
## Steps
- Follow the directive to update the framework
    - Ref: https://blog.csdn.net/sD7O95O/article/details/107437558
- Update all NUGET package to correct version

## Refactoring
- Rebuild the seriolog
    - Ref: https://codewithmukesh.com/blog/serilog-in-aspnet-core-3-1/

- Add IOC Configuration file to make the IOC Injection more clear
    - Place into a common file: IocConfiguration.cs for all the DI Configuration

- Add automapper to map db structure
    - https://procodeguide.com/programming/automapper-in-aspnet-core/

- Add unit test
## TODO: 
- Add transaction for save service 

- Migrate the api to rest api 