using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ToDoWebApp_CodeBehind.Models;

public class ToDoModel
{
    [Key]
    [JsonPropertyName("id")]
    public int id { get; set; }

    [JsonPropertyName("taskName")]
    [Display(Name="Name")]
    public string name { get; set; }
    
    [JsonPropertyName("completed")]
    [Display(Name ="Completed?")]
    public bool isCompleted { get; set; }
}