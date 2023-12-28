﻿using Shared.Features.DomainKernel.Interfaces;

namespace Shared.Features.CQRS.Features.DomainKernelEvent
{
    public interface IDomainEventHandler<in TDomainEvent> where TDomainEvent : IDomainEvent
    {
        Task HandleAsync(TDomainEvent query, CancellationToken cancellation);
    }
}
