// See https://aka.ms/new-console-template for more information
using (var client = new HttpClient())
{
    client.BaseAddress = new Uri("https://intest.sonata-software.com/api/api/");
    //HTTP GET 
    var responseTask = client.GetAsync("skill");
    responseTask.Wait();

    var result = responseTask.Result;
    if (result.IsSuccessStatusCode)
    {
        var readTask = result.Content.ReadAsStringAsync();
        readTask.Wait();

        Console.WriteLine(readTask.Result);

    }
}
Console.ReadLine();
