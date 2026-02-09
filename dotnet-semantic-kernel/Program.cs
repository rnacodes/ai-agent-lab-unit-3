using System;
using SemanticKernelAgent;
using Microsoft.Extensions.Configuration;

// Entry point of the application
Console.WriteLine("Welcome to the Semantic Kernel AI Agent!");

// Load configuration from environment variables and user secrets
var configuration = new ConfigurationBuilder()
    .AddEnvironmentVariables()
    .AddUserSecrets<Program>()
    .Build();

// Retrieve the GitHub token from configuration
var githubToken = configuration["GITHUB_TOKEN"];

if (string.IsNullOrEmpty(githubToken))
{
    Console.WriteLine("❌ Error: GITHUB_TOKEN not found. Please set it as an environment variable or add it to user secrets.");
    return;
}

Console.WriteLine("✅ GITHUB_TOKEN loaded successfully!");

// Your code logic goes here
Console.WriteLine("This is a basic setup for the Semantic Kernel AI Agent.");