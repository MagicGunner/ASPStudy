using ASPDemo1.Model;
using AutoMapper;

namespace ASPDemo1.Extension.ServiceExtension;

public class CustomProfile : Profile {
    public CustomProfile() {
        CreateMap<Role, RoleVo>().ForMember(a => a.RoleName, o => o.MapFrom(d => d.Name));
        CreateMap<RoleVo, Role>().ForMember(a => a.Name, o => o.MapFrom(d => d.RoleName));
    }
}