﻿namespace Adnc.Demo.Usr.Repository;

public class EntityInfo : AbstractEntityInfo
{
    protected override List<Assembly> GetCurrentAssemblies() => [GetType().Assembly, typeof(EventTracker).Assembly];

    protected override void SetTableName(dynamic modelBuilder)
    {
        if (modelBuilder is not ModelBuilder builder)
            throw new ArgumentNullException(nameof(modelBuilder));

        builder.Entity<EventTracker>().ToTable("sys_eventtracker");
        builder.Entity<Organization>().ToTable("sys_organization");
        builder.Entity<Menu>().ToTable("sys_menu");
        builder.Entity<Role>().ToTable("sys_role");
        builder.Entity<RoleMenuRelation>().ToTable("sys_role_menu_relation");
        builder.Entity<RoleUserRelation>().ToTable("sys_role_user_relation");
        builder.Entity<User>().ToTable("sys_user");
    }
}