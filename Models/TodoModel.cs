using System.Text.Json.Serialization;
using System.Security.Cryptography;

namespace ToDoWebApp_CodeBehind.Models;

public record ToDoModel
{
    [JsonConstructor]
    public ToDoModel(int Id, string Name, bool InStock)
    {
        id = Id;
        name = Name;
        inStock = InStock;
    }

    // Parameterless constructor for instantiation
    public ToDoModel(string Name, bool InStock)
        : this(GenerateUniqueId(), Name, InStock)
    {

    }

    [JsonPropertyName("id")]
    public int id { get; set; }

    [JsonPropertyName("taskName")]
    public string name { get; set; }
    
    [JsonPropertyName("completed")]
    public bool inStock { get; set; }

    private static int GenerateUniqueId()
    {
        // Generate a Guid and take the first 4 bytes, converting them to an integer
        var guid = Guid.NewGuid();
        return BitConverter.ToInt32(guid.ToByteArray(), 0);
    }
}