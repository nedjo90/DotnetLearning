namespace AsyncAndAwait;

class Program
{
    static async Task Main(string[] args)
    {
        HttpClient client = new HttpClient();
        HttpResponseMessage response = await client.GetAsync("http://www.apple.com/");
        WriteLine("Apple's home page has {0:N0} bytes.", response.Content.Headers.ContentLength);
        foreach (KeyValuePair<string,IEnumerable<string>> keyValuePair in response.Headers)
        {
            WriteLine($"{keyValuePair.Key} => ");
            foreach (string s in keyValuePair.Value)
            {
                WriteLine($"\t{s}");
            }
        }
    }
}