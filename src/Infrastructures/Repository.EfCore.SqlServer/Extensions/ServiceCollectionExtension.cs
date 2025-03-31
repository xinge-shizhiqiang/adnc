﻿using System.Reflection;
using Adnc.Infra.Repository.EfCore.SqlServer;
using Adnc.Infra.Repository.EfCore.SqlServer.Transaction;
using Adnc.Infra.Repository.Interceptor.Castle;

namespace Microsoft.Extensions.DependencyInjection;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddAdncInfraEfCoreSQLServer(this IServiceCollection services, Assembly assembly, Action<DbContextOptionsBuilder> optionsBuilder, ServiceLifetime serviceLifetime = ServiceLifetime.Scoped)
    {
        ArgumentNullException.ThrowIfNull(services, nameof(services));
        ArgumentNullException.ThrowIfNull(assembly, nameof(assembly));
        ArgumentNullException.ThrowIfNull(optionsBuilder, nameof(optionsBuilder));

        if (services.HasRegistered(nameof(AddAdncInfraEfCoreSQLServer)))
        {
            return services;
        }

        services.AddDbContext<DbContext, SqlServerDbContext>(optionsBuilder, serviceLifetime);
        services.Add(new ServiceDescriptor(typeof(IUnitOfWork), typeof(SqlServerUnitOfWork<SqlServerDbContext>), serviceLifetime));
        services.Add(new ServiceDescriptor(typeof(UowInterceptor), typeof(UowInterceptor), serviceLifetime));
        services.Add(new ServiceDescriptor(typeof(UowAsyncInterceptor), typeof(UowAsyncInterceptor), serviceLifetime));
        services.Add(new ServiceDescriptor(typeof(IEfRepository<>), typeof(EfRepository<>), serviceLifetime));
        services.Add(new ServiceDescriptor(typeof(IEfBasicRepository<>), typeof(EfBasicRepository<>), serviceLifetime));

        var serviceType = typeof(IEntityInfo);
        var implType = assembly.ExportedTypes.Single(type => type.IsAssignableTo(serviceType) && type.IsNotAbstractClass(true));
        services.Add(new ServiceDescriptor(serviceType, implType, serviceLifetime));

        return services;
    }
}
