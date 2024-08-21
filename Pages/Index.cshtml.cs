using Microsoft.AspNetCore.Mvc.RazorPages;
using ToDoWebApp_CodeBehind.Models;
using System.Text.Json;
using Microsoft.Net.Http.Headers;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ToDoWebApp_CodeBehind.Pages 
{
    public class IndexModel : PageModel 
    {
        // IttpClientFactory set using dependency injection
        private readonly IHttpClientFactory _httpclientFactory;
        public IndexModel (IHttpClientFactory httpClientFactory){
            _httpclientFactory = httpClientFactory;
        }
        // Add the data model and bind the fore data to the page model properties
        // Enumerable since an array is expected as a response 
        [BindProperty]
        public IEnumerable<ToDoModel> ToDoModels { get; set; }

        // Begin GET operation code

    // Comments
    // onGet() is async since HTTP requests should be performed async

    // Code:
        public async Task OnGet() 
        {
            // Create the HTTP client using the TODOAPI nased factory
            var httpClient = _httpclientFactory.CreateClient("ToDoAPI");
            // Comments
                // Perform the GET request and store the response. The empty parameter
                // In GetAsync doesn't modify the base address set in the client factory
            using HttpResponseMessage response = await httpClient.GetAsync("");
            {
                // If the request is successful deserialize the results into the data model
                // Code
                if (response.IsSuccessStatusCode)
                {
                    using var contentStream = await response.Content.ReadAsStreamAsync();

                    Debug.WriteLine("Debug info: variable x = test");
                    Trace.WriteLine("Trace info: variable x = test line");

                    ToDoModels = await JsonSerializer.DeserializeAsync<IEnumerable<ToDoModel>>(contentStream);
                }
            }
            // End GET operation code
        }
    }
}