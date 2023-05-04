﻿global using ApiModels = Microsoft.eShopOnContainers.Services.Ordering.API.Application.Models;
global using AppCommand = Microsoft.eShopOnContainers.Services.Ordering.API.Application.Commands;
global using Azure.Core;
global using Azure.Identity;
global using Dapper;
global using FluentValidation;
global using Google.Protobuf.Collections;
global using Grpc.Core;
global using HealthChecks.UI.Client;
global using MediatR;
global using Microsoft.AspNetCore.Authorization;
global using Microsoft.AspNetCore.Builder;
global using Microsoft.AspNetCore.Diagnostics.HealthChecks;
global using Microsoft.AspNetCore.Hosting;
global using Microsoft.AspNetCore.Http;
global using Microsoft.AspNetCore.Mvc.Authorization;
global using Microsoft.AspNetCore.Mvc.Filters;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.AspNetCore.Server.Kestrel.Core;
global using Microsoft.AspNetCore;
global using Microsoft.EntityFrameworkCore.Design;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.eShopOnContainers.BuildingBlocks.EventBus.Abstractions;
global using Microsoft.eShopOnContainers.BuildingBlocks.EventBus.Events;
global using Microsoft.eShopOnContainers.BuildingBlocks.EventBus.Extensions;
global using Microsoft.eShopOnContainers.BuildingBlocks.EventBus;
global using Microsoft.eShopOnContainers.BuildingBlocks.EventBusRabbitMQ;
global using Microsoft.eShopOnContainers.BuildingBlocks.EventBusServiceBus;
global using Microsoft.eShopOnContainers.BuildingBlocks.IntegrationEventLogEF.Services;
global using Microsoft.eShopOnContainers.BuildingBlocks.IntegrationEventLogEF;
global using Microsoft.eShopOnContainers.Services.Ordering.API.Application.Behaviors;
global using Microsoft.eShopOnContainers.Services.Ordering.API.Application.Commands;
global using Microsoft.eShopOnContainers.Services.Ordering.API.Application.DomainEventHandlers;
global using Microsoft.eShopOnContainers.Services.Ordering.API.Application.IntegrationEvents;
global using Microsoft.eShopOnContainers.Services.Ordering.API.Application.IntegrationEvents.Events;
global using Microsoft.eShopOnContainers.Services.Ordering.API.Application.IntegrationEvents.EventHandling;
global using Microsoft.eShopOnContainers.Services.Ordering.API.Application.Models;
global using Microsoft.eShopOnContainers.Services.Ordering.API.Application.Queries;
global using Microsoft.eShopOnContainers.Services.Ordering.API.Application.Validations;
global using Microsoft.eShopOnContainers.Services.Ordering.API.Controllers;
global using Microsoft.eShopOnContainers.Services.Ordering.API.Extensions;
global using Microsoft.eShopOnContainers.Services.Ordering.API.Infrastructure.ActionResults;
global using Microsoft.eShopOnContainers.Services.Ordering.API.Infrastructure.Filters;
global using Microsoft.eShopOnContainers.Services.Ordering.API.Infrastructure.Services;
global using Microsoft.eShopOnContainers.Services.Ordering.API.Infrastructure;
global using Microsoft.eShopOnContainers.Services.Ordering.API;
global using Microsoft.eShopOnContainers.Services.Ordering.Domain.AggregatesModel.BuyerAggregate;
global using Microsoft.eShopOnContainers.Services.Ordering.Domain.AggregatesModel.OrderAggregate;
global using Microsoft.eShopOnContainers.Services.Ordering.Domain.Events;
global using Microsoft.eShopOnContainers.Services.Ordering.Domain.Exceptions;
global using Microsoft.eShopOnContainers.Services.Ordering.Domain.SeedWork;
global using Microsoft.eShopOnContainers.Services.Ordering.Infrastructure.Idempotency;
global using Microsoft.eShopOnContainers.Services.Ordering.Infrastructure.Repositories;
global using Microsoft.eShopOnContainers.Services.Ordering.Infrastructure;
global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Diagnostics.HealthChecks;
global using Microsoft.Extensions.Hosting;
global using Microsoft.Extensions.Logging;
global using Microsoft.Extensions.Options;
global using Microsoft.OpenApi.Models;
global using Polly.Retry;
global using Polly;
global using RabbitMQ.Client;
global using Swashbuckle.AspNetCore.SwaggerGen;
global using System.Collections.Generic;
global using System.Data.Common;
global using System.Data.SqlClient;
global using System.IdentityModel.Tokens.Jwt;
global using System.IO;
global using System.Linq;
global using System.Net;
global using System.Reflection;
global using System.Runtime.Serialization;
global using System.Threading.Tasks;
global using System.Threading;
global using System;
