﻿using Microsoft.AspNetCore.Builder;

namespace Ocelot.DownstreamPathManipulation.Middleware;

public static class ClaimsToDownstreamPathMiddlewareExtensions
{
    public static IApplicationBuilder UseClaimsToDownstreamPathMiddleware(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<ClaimsToDownstreamPathMiddleware>();
    }
}
