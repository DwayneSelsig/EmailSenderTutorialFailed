namespace BlazorApp8.Services
{
    public class AuthMessageSenderOptions
    {
        public string? SendGridKey { get; set; }

        public AuthMessageSenderOptions()
        {
            //skipping tutorial explaining user secrets.json https://learn.microsoft.com/en-us/aspnet/core/security/authentication/accconfirm?view=aspnetcore-8.0&tabs=visual-studio#configure-sendgrid-user-secrets
            //hardcoding SendGridKey for now
            SendGridKey = "";
        }
    }
}
