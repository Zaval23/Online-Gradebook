namespace OnlineGradebook.Service.Settings
{
    public static class OnlineGradebookSettingsReader
    {
        public static OnlineGradebookSettings Read(IConfiguration configuration)
        {
            return new OnlineGradebookSettings()
            {
                OnlineGradebookDbConnectionString =
                    configuration.GetConnectionString("OnlineGradebookDbConnectionString"),
            };
        }
    }
}