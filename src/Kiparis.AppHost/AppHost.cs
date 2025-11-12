// Copyright (c) Parusnik-Belgorod, LLC. All rights reserved.
// See LICENSE file in the project root for license information.

var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Kiparis_Integration_Svod31_Reporting_Api>("kiparis-integration-svod31-reporting-api");

builder.Build().Run();
