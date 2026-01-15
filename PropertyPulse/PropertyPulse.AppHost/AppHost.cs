var builder = DistributedApplication.CreateBuilder(args);

var postgres = builder.AddPostgres("postgres")
    .AddDatabase("propertydb");

var redis = builder.AddRedis("redis");

var apiService = builder.AddProject<Projects.PropertyPulse_ApiService>("apiservice")
    .WithReference(postgres)
    .WithReference(redis)
    .WithHttpHealthCheck("/health");

builder.AddNpmApp("webfrontend", "../PropertyPulse.WebFrontend")
    .WithHttpEndpoint(targetPort: 5173, name: "http")
    .WithReference(apiService)
    .WithHttpHealthCheck("/")
    .WithExternalHttpEndpoints()
    .WaitFor(apiService);

builder.Build().Run();
