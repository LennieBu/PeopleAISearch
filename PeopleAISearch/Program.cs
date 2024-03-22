using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.Connectors.OpenAI;
using Newtonsoft.Json;
using PeopleAISearch.Data;

namespace PeopleAISearch
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var builder = Kernel.CreateBuilder();

            //using OpenAI
            builder.AddOpenAIChatCompletion(
                     "gpt-3.5-turbo",                  // OpenAI Model name
                     "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");     // OpenAI API Key

            var kernel = builder.Build();

            var prompt = new Prompts();

            var data = new PersonData().People; //Mock data

            string dataString = JsonConvert.SerializeObject(data);

            var summarize = kernel.CreateFunctionFromPrompt(prompt.FindRecord(dataString, "1999"), 
                executionSettings: new OpenAIPromptExecutionSettings { MaxTokens = 300 });

            Console.WriteLine(await kernel.InvokeAsync(summarize));
        }
    }
}