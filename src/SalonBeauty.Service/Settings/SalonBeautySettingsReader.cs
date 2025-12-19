namespace SalonBeauty.Service.Settings
{
    public static class SalonBeautySettingsReader
    {
        public static SalonBeautySettings Read(IConfiguration configuration)
        {
            return new SalonBeautySettings()
            {
                SalonBeautyDbConnectionString =
                    configuration.GetConnectionString("SalonBeautyDbConnectionString"),
            };
        }
    }
}