// Copyright (c) Parusnik-Belgorod, LLC. All rights reserved.
// See LICENSE file in the project root for license information.

var builder = WebApplication.CreateSlimBuilder(args);

builder.AddServiceDefaults();

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

app.MapDefaultEndpoints();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.MapGet("/", () => "Kiparis Integration Svod31 Reporting API is running...");

app.Run();
