using AutoMapper;

namespace ASPDemo1.Extensions;

public class AutoMapperConfig {
    public static MapperConfiguration RegisterMappings() {
        return new MapperConfiguration(cfg => cfg.AddProfile(new CustomProfile()));
    }
}