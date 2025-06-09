using System.Reflection;
using ASPDemo1.IService;
using ASPDemo1.Repository.Base;
using ASPDemo1.Service;
using Autofac;
using Module = Autofac.Module;

namespace ASPDemo1.Extension.ServiceExtension;

public class AutofacModuleRegister : Module {
    protected override void Load(ContainerBuilder builder) {
        var basePath = AppContext.BaseDirectory;

        var servicesDllFile = Path.Combine(basePath, "ASPDemo1.Service.dll");
        var repositoryDllFile = Path.Combine(basePath, "ASPDemo1.Repository.dll");

        builder.RegisterGeneric(typeof(BaseRepository<>)).As(typeof(IBaseRepository<>)).InstancePerDependency();
        builder.RegisterGeneric(typeof(BaseService<,>)).As(typeof(IBaseService<,>)).InstancePerDependency();

        var assemblyService = Assembly.LoadFrom(servicesDllFile);
        builder.RegisterAssemblyTypes(assemblyService).AsImplementedInterfaces().InstancePerDependency().PropertiesAutowired();

        var assemblyRepository = Assembly.LoadFrom(repositoryDllFile);
        builder.RegisterAssemblyTypes(assemblyRepository).AsImplementedInterfaces().InstancePerDependency().PropertiesAutowired();
    }
}