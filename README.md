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

- Add swagger 
    - https://coderjony.com/blogs/adding-swagger-to-aspnet-core-31-web-api/
    - Not work yet, should change some api to respect rest api
- Add unit test
    - NUnit 
    - EF CORE InMemory context 
## TODO: 
- Add log for all save services
- Add transaction for save service
- Migrate the api to rest api

# Deploiement:
- If you want to deploy it to UAT(Staging), just need to review your deploiment on action
- If you want to deploy it to Prod, please create a new tag
