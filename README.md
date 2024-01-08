# BlazorApp8

Followed the tutorial on https://learn.microsoft.com/en-us/aspnet/core/security/authentication/accconfirm?view=aspnetcore-8.0&tabs=visual-studio

Getting error:

|Severity|Code|Description|Project|File|Line|Suppression State|
|--------|----|-----------|-------|----|----|-----------------|
|Error|CS0311|The type 'BlazorApp8.Services.EmailSender' cannot be used as type parameter 'TImplementation' in the generic type or method 'ServiceCollectionServiceExtensions.AddSingleton<TService, TImplementation>(IServiceCollection)'. There is no implicit reference conversion from 'BlazorApp8.Services.EmailSender' to 'Microsoft.AspNetCore.Identity.IEmailSender<BlazorApp8.Data.ApplicationUser>'.|BlazorApp8|\BlazorApp8\Program.cs|38|Active|
