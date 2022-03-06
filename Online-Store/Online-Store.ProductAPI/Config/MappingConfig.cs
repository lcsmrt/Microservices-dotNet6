using AutoMapper;

namespace Online_Store.ProductAPI.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration();
            return mappingConfig;
        }
    }
}
