// ************************************************************************
// <copyright file="Startup.cs" company="Runic Bytes">
// Copyright (c) Runic Bytes - All rights reserved.
// </copyright>
// ************************************************************************

namespace RunicBytes.CleanTemplate.Presentation
{
    /// <summary>
    /// The necessary configurations for the application.
    /// </summary>
    public class Startup
    {
        private readonly IConfiguration configuration;

        /// <summary>
        /// Creates an instance.
        /// </summary>
        public Startup()
        {
            IConfigurationBuilder builder = new ConfigurationBuilder().SetBasePath(Path.Combine(AppContext.BaseDirectory))
                                                                      .AddJsonFile("appsettings.json", optional: true);
            this.configuration = builder.Build();
        }

        /// <summary>
        /// Performs Dependency Injection configurations.
        /// </summary>
        /// <param name="services">Service collection.</param>
        public void ConfigureServices(IServiceCollection services)
        {
        }

        /// <summary>
        /// Configures the application request pipeline.
        /// </summary>
        /// <param name="applicationBuilder">The mechanism that manages the application's request data flow.</param>
        /// <param name="lifetime">Allows consumers to be notified of application lifetime events.</param>
        public void Configure(IApplicationBuilder applicationBuilder, IHostApplicationLifetime lifetime)
        {
        }
    }
}
