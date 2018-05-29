using Microsoft.Extensions.DependencyInjection;
using presurgeryapp.Models;

namespace presurgeryapp.IoC
{
    public static class IoC
    {
        public static ApplicationDbContext applicationDbContext => IocContainer.Provider.GetService<ApplicationDbContext>();
    }

    public static class IocContainer
    {
        public static ServiceProvider Provider { get; set; }
    }
}
