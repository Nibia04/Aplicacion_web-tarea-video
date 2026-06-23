var builder = DistributedApplication.CreateBuilder(args);

var dbserver = builder.AddPostgres("dbserver").WithLifetime(ContainerLifetime.Persistent);
dbserver.WithPgAdmin(optiones =>
optiones.WithHostPort(5555).WithLifetime(ContainerLifetime.Persistent)
);
var db = dbserver.AddDatabase("db");

builder.AddProject<Projects.apiB>("api").WithExternalHttpEndpoints().WithReference(db).WaitFor(dbserver);

builder.Build().Run();
