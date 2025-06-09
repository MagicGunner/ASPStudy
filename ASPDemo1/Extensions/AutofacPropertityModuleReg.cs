using Autofac;
using Microsoft.AspNetCore.Mvc;

namespace ASPDemo1.Extensions;

public class AutofacPropertyModuleReg : Module {
    protected override void Load(ContainerBuilder builder) {
        // 获取 ControllerBase 类型
        var controllerBaseType = typeof(ControllerBase);

        // 在当前程序集中查找所有继承自 ControllerBase 的类型
        builder.RegisterAssemblyTypes(typeof(Program).Assembly)
               .Where(t => controllerBaseType.IsAssignableFrom(t) && t != controllerBaseType)
               .PropertiesAutowired(); // 启用属性注入
    }
}