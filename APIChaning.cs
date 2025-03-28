using RestSharp;
using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        var client = new RestClient("https://petstore.swagger.io/v2");

        // Create a new pet "Fluffy"
        var createRequest = new RestRequest("/pet", Method.Post);
        var petData = new
        {
            id = 28041981, // Unique ID
            name = "Fluffy",
            status = "available"
        };
        createRequest.AddJsonBody(petData);
        var createResponse = client.Execute(createRequest);
        Console.WriteLine($"Pet Created: {createResponse.Content}");

        // Add a short delay to allow Petstore to process creation
        Thread.Sleep(2000);

        // Retrieve the created pet
        var petId = petData.id;
        var getRequest = new RestRequest($"/pet/{petId}", Method.Get);
        var getResponse = client.Execute(getRequest);
        Console.WriteLine($"Retrieved Pet: {getResponse.Content}");

        // Step 3: Update "Fluffy" to "Fuzzy"
        var updateRequest = new RestRequest("/pet", Method.Put);
        var updatedPetData = new
        {
            id = petId,
            name = "Fuzzy",
            status = "available"
        };
        updateRequest.AddJsonBody(updatedPetData);
        var updateResponse = client.Execute(updateRequest);
        Console.WriteLine($"Updated Pet: {updateResponse.Content}");

        // Delete "Fuzzy"
        var deleteRequest = new RestRequest($"/pet/{petId}", Method.Delete);
        var deleteResponse = client.Execute(deleteRequest);
        Console.WriteLine($"Deleted Pet: {deleteResponse.Content}");
    }
}