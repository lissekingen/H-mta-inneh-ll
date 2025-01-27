using System.Net.Http;
using System.Text.Json;

class Program{
  async static Task Main(){
    JsonSerializerOptions options = new JsonSerializerOptions{
      WriteIndented=true
    };
  using(HttpClient tysken = new HttpClient()){
    tysken.BaseAddress = new Uri ("https://api.chucknorris.io");
    try{
HttpResponseMessage response = await tysken.GetAsync("jokes/random");
response.EnsureSuccessStatusCode();
string responseBody = await response.Content.ReadAsStringAsync();
string Jsonstring = JsonSerializer.Serialize(responseBody,options);
Console.WriteLine(Jsonstring);
}
catch(HttpRequestException e){
  Console.WriteLine(e.Message);
}
}
  }
  
}

