﻿using Modules.TenantIdentity.Features.Aggregates.UserAggregate;

namespace Modules.TenantIdentity.Features.EFCore
{
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            
        }
    }
}
