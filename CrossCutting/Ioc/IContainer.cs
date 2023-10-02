﻿// Innovt Company
// Author: Michel Borges
// Project: Innovt.Core

using System;
using Microsoft.Extensions.DependencyInjection;

namespace Innovt.Core.CrossCutting.Ioc;

/// <summary>
/// Represents an interface for a dependency injection container.
/// </summary>
/// <remarks>
/// This interface defines a contract for a dependency injection container that provides methods for
/// registering modules, resolving services, releasing resources, and creating service scopes.
/// It also includes a method for checking container configuration.
/// </remarks>
public interface IContainer : IDisposable
{
    /// <summary>
    /// Adds an <see cref="IOCModule"/> to the container.
    /// </summary>
    /// <param name="iocModule">The <see cref="IOCModule"/> to be added to the container.</param>
    void AddModule(IOCModule iocModule);

    /// <summary>
    /// Resolves a service of the specified <paramref name="type"/>.
    /// </summary>
    /// <param name="type">The <see cref="Type"/> of the service to resolve.</param>
    /// <returns>The resolved service object.</returns>
    object Resolve(Type type);

    /// <summary>
    /// Resolves a service of type <typeparamref name="TService"/>.
    /// </summary>
    /// <typeparam name="TService">The type of service to resolve.</typeparam>
    /// <returns>The resolved service object.</returns>
    TService Resolve<TService>();

    /// <summary>
    /// Resolves a service of type <typeparamref name="TService"/> with the specified <paramref name="type"/>.
    /// </summary>
    /// <typeparam name="TService">The type of service to resolve.</typeparam>
    /// <param name="type">The <see cref="Type"/> of the service implementation to resolve.</param>
    /// <returns>The resolved service object.</returns>
    TService Resolve<TService>(Type type);

    /// <summary>
    /// Resolves a named instance of a service of type <typeparamref name="TService"/>.
    /// </summary>
    /// <typeparam name="TService">The type of service to resolve.</typeparam>
    /// <param name="instanceKey">The key identifying the named instance to resolve.</param>
    /// <returns>The resolved service object.</returns>
    TService Resolve<TService>(string instanceKey);

    /// <summary>
    /// Releases the specified object and frees associated resources.
    /// </summary>
    /// <param name="obj">The object to release.</param>
    void Release(object obj);


    /// <summary>
    /// Creates and returns a new service scope.
    /// </summary>
    /// <returns>An <see cref="IServiceScope"/> representing the new service scope.</returns>
    IServiceScope CreateScope();

    /// <summary>
    /// Checks the configuration of the container.
    /// </summary>
    void CheckConfiguration();
}