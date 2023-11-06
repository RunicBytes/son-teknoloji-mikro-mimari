// ************************************************************************
// <copyright file="Program.cs" company="Runic Bytes">
// Copyright (c) Runic Bytes - All rights reserved.
// </copyright>
// ************************************************************************

namespace RunicBytes.CleanTemplate.Presentation
{
    using Microsoft.AspNetCore.Hosting;

    /// <summary>
    /// The entry point Class for the REST API.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The entry point of the REST API.
        /// </summary>
        public static void Main()
        {
            try
            {
                IHostBuilder hostBuilder = CreateHostBuilder();
                hostBuilder.Build();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        /// <summary>
        /// Performs the necessary configurations for the Web Host.
        /// </summary>
        /// <returns>Web Host.</returns>
        public static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                       .ConfigureWebHostDefaults(webBuilder =>
                       {
                           webBuilder.UseKestrel()
                                     .UseContentRoot(Directory.GetCurrentDirectory())
                                     .UseUrls("https://+:1923");

                           webBuilder.UseStartup<Startup>();
                       });
        }
    }
}
