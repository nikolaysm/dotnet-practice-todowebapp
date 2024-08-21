using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ToDoWebApp_CodeBehind.Models;
using System.Text.Json;
using Microsoft.AspNetCore.Components;
using System.Text;
using System.Diagnostics;

namespace ToDoWebApp_CodeBehind.Pages
{
    public class AddModel : PageModel
    {
        // IHttpClientFactory set using dependency injection 
        private readonly IHttpClientFactory _httpClientFactory;

        // Constructor to inject IHttpClientFactory using expression-bodied syntax
        public AddModel(IHttpClientFactory httpClientFactory) => _httpClientFactory = httpClientFactory;

        // Add the data model and bind the form data to the page model properties
        [BindProperty]
        public ToDoModel ToDoModels { get; set; }

        // Handles GET requests, returns the page
        public IActionResult OnGet()
        {
            return Page();
        }

        // Begin POST operation code
        public async Task<IActionResult> OnPostAsync()
        {
            // Serialize the information to be added to the database
            var jsonContent = new StringContent(JsonSerializer.Serialize(ToDoModels),
                Encoding.UTF8,
                "application/json");
            
            // Create the HTTP client using the FruitAPI named factory
            var httpClient = _httpClientFactory.CreateClient("ToDoAPI");
            
            // Execute the POST request and store the response. The parameters in PostAsync 
            // direct the POST to use the base address and passes the serialized data to the API
            using HttpResponseMessage response = await httpClient.PostAsync("", jsonContent);
            
            // Return to the home (Index) page and add a temporary success/failure 
            // message to the page.
            if (response.IsSuccessStatusCode)
            {
                TempData["success"] = "Data was added successfully.";
                return RedirectToPage("Index");
            }
            else
            {
                TempData["failure"] = "Operation was not successful";
                return RedirectToPage("Index");
            }
        }
        // End POST operation code
    }
}

