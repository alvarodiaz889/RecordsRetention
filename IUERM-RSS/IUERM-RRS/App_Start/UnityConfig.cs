using IUERM_RRS.Repositories;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace IUERM_RRS
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            container.RegisterType<IRoleRepository, RoleRepositoryImpl>();
            container.RegisterType<IUserRepository, UserRepositoryImpl>();
            container.RegisterType<IScheduleRepository, ScheduleRepositoryImpl>();
            container.RegisterType<IMainRepository, MainRepositoryImpl>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}