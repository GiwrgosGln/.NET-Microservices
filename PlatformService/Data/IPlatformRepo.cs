namespace PlatformService.Data
{
    public interface IPlatformRepo
    {
        bool SaveChanges();
        IEnumerable<Platform> GetAllPlatforms();
        PlatformService GetPlatformById(int id);
        void CreatePlatform(Platform plat);
    }
}