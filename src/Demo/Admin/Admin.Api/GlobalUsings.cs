﻿global using Adnc.Demo.Admin.Application.Contracts.Dtos;
global using Adnc.Demo.Admin.Application.Contracts.Services;
global using Adnc.Demo.Const;
global using Adnc.Demo.Const.Permissions.Admin;
global using Adnc.Shared;
global using Adnc.Shared.Application.Contracts.Dtos;
global using Adnc.Shared.WebApi;
global using Adnc.Shared.WebApi.Authentication;
global using Adnc.Shared.WebApi.Authentication.Bearer;
global using Adnc.Shared.WebApi.Authorization;
global using Microsoft.AspNetCore.Authorization;
global using Microsoft.AspNetCore.Builder;
global using Microsoft.AspNetCore.Http;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Hosting;
global using Microsoft.Extensions.Options;
global using System.IdentityModel.Tokens.Jwt;
