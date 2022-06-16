using System.Collections.Generic;
using PlatformService.Models;

namespace PlatformService.Data
{
    public interface IPlatformRepo
    {
        void CreatePaltform(Platform plat);
        IEnumerable<Platform> GetAllPlatforms();
        Platform GetPlatformById(int id);
        bool SaveChanges();
    }
}