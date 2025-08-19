﻿using Azure;
using Azure.AI.Agents.Persistent;
using Azure.Identity;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.Agents;
using Microsoft.SemanticKernel.Agents.AzureAI;
using Microsoft.SemanticKernel.ChatCompletion;

#pragma warning disable SKEXP0110

// Agent setup
string agentId = "asst_uZThW1LeE27HEUBxFR3DU4Wi";
string endpoint = "https://fcmalanaifoundry-resource.services.ai.azure.com/api/projects/fcmalanaifoundry";

PersistentAgentsClient client = AzureAIAgent.CreateAgentsClient(endpoint, new DefaultAzureCredential());
//await client.Administration.CreateAgentAsync("model", "name", "description", "instructions" /*tools, etc*/);
PersistentAgent definition = await client.Administration.GetAgentAsync(agentId);

AzureAIAgent agent = new(definition, client);

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine();
Console.WriteLine("****************************************");
Console.WriteLine("       Welcome to Calc-U-Later!        ");
Console.WriteLine("****************************************");
Console.WriteLine("I’m your friendly Calculator Agent — here’s what I can do: 😊");
Console.WriteLine("• Add numbers");
Console.WriteLine("• Subtract numbers");
Console.WriteLine("• Multiply numbers");
Console.WriteLine("• Divide numbers");
Console.WriteLine("• Powers / Exponents");
Console.WriteLine("• Roots");
Console.WriteLine("• Percentages");
Console.WriteLine("• Complex expressions with parentheses");
Console.WriteLine("Type your question and press Enter. Type 'exit' to quit.\n");
Console.ResetColor();

await AgentChat();

async Task AgentChat()
{
    AzureAIAgentThread agentThread = new(agent.Client);
    try
    {
        while (true)
        {
            Console.Write("You: ");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
                continue;

            if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                break;

            ChatMessageContent message = new(AuthorRole.User, input);

            await foreach (AgentResponseItem<ChatMessageContent> item in agent.InvokeAsync(message, agentThread))
            {
                Console.WriteLine($"Calc-U-Later: {item.Message.Content}");
                Console.ResetColor();
            }
        }
    }
    finally
    {
        await agentThread.DeleteAsync();
    }
}
