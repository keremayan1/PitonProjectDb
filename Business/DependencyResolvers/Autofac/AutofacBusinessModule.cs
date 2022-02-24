using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Module = Autofac.Module;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<PlanStatusManager>().As<IPlanStatusService>().SingleInstance();
            builder.RegisterType<EfPlanStatusDal>().As<IPlanStatusDal>().SingleInstance();

            builder.RegisterType<PlanManager>().As<IPlanService>().SingleInstance();
            builder.RegisterType<EfPlanDal>().As<IPlanDal>().SingleInstance();

            var assembly = Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces().EnableInterfaceInterceptors(new ProxyGenerationOptions
            {
                Selector = new AspectInterceptorSelector()
            }).SingleInstance().InstancePerDependency();
        }
    }
}
