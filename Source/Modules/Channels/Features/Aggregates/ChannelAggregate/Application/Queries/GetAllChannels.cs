﻿using Modules.Channels.Features.Infrastructure.EFCore;
using Shared.Features.CQRS.Query;

namespace Modules.Channels.Features.Aggregates.ChannelAggregate.Application.Queries
{
    public class GetAllChannels : IQuery<List<Channel>>
    {

    }
    public class AllChannelsQueryHandler : BaseQueryHandler<ChannelsDbContext, Channel>, IQueryHandler<GetAllChannels, List<Channel>>
    {
        public AllChannelsQueryHandler(ChannelsDbContext applicationDbContext) : base(applicationDbContext) { }
        public async Task<List<Channel>> HandleAsync(GetAllChannels query, CancellationToken cancellation)
        {
            return dbSet.ToList();
        }
    }
}
