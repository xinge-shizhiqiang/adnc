﻿global using System.Linq.Expressions;
global using System.Net;
global using System.Reflection;
global using System.Text.Json;
global using Adnc.Infra.Core.DependencyInjection;
global using Adnc.Infra.Core.Json;
global using Adnc.Infra.IdGenerater.Yitter;
global using Adnc.Infra.Redis.Caching.Interceptor.Castle;
global using Adnc.Infra.Repository;
global using Adnc.Shared.Application.Contracts.Attributes;
global using Adnc.Shared.Application.Contracts.Enums;
global using Adnc.Shared.Application.Contracts.Interfaces;
global using Adnc.Shared.Application.Contracts.ResultModels;
global using Adnc.Shared.Application.Interceptors;
global using Adnc.Shared.Application.Mapper;
global using Adnc.Shared.Repository.DapperEntities;
global using Adnc.Shared.Repository.EfCoreEntities;
global using Castle.DynamicProxy;
global using FluentValidation;
global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Hosting;
global using Microsoft.Extensions.Logging;
global using Polly;
