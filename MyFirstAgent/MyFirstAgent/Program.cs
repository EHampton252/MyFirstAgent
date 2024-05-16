using Microsoft.SemanticKernel;
using Kernel = Microsoft.SemanticKernel.Kernel;
using System.Runtime;
using System;


var (useAzureOpenAI, model, azureEndpoint, apiKey, orgId) = Settings.LoadFromFile();
var builder = Kernel.CreateBuilder();

builder.Services.AddAzureOpenAIChatCompletion(model, azureEndpoint, apiKey);

var result = await kernel.InvokePromptAsync(
        "Give me a list of breakfast foods with eggs and cheese");
Console.WriteLine(result);