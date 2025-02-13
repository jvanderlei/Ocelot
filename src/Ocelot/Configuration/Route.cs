﻿using Ocelot.Configuration.File;
using Ocelot.Values;

namespace Ocelot.Configuration;

public class Route
{
    public Route(List<DownstreamRoute> downstreamRoute,
        List<AggregateRouteConfig> downstreamRouteConfig,
        List<HttpMethod> upstreamHttpMethod,
        UpstreamPathTemplate upstreamTemplatePattern,
        string upstreamHost,
        string aggregator,
        IDictionary<string, UpstreamHeaderTemplate> upstreamHeaderTemplates)
    {
        UpstreamHost = upstreamHost;
        DownstreamRoute = downstreamRoute;
        DownstreamRouteConfig = downstreamRouteConfig;
        UpstreamHttpMethod = upstreamHttpMethod;
        UpstreamTemplatePattern = upstreamTemplatePattern;
        Aggregator = aggregator;
        UpstreamHeaderTemplates = upstreamHeaderTemplates;
    }

    public IDictionary<string, UpstreamHeaderTemplate> UpstreamHeaderTemplates { get; }
    public UpstreamPathTemplate UpstreamTemplatePattern { get; }
    public List<HttpMethod> UpstreamHttpMethod { get; }
    public string UpstreamHost { get; }
    public List<DownstreamRoute> DownstreamRoute { get; }
    public List<AggregateRouteConfig> DownstreamRouteConfig { get; }
    public string Aggregator { get; }
}
