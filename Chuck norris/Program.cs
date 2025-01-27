using System.Net.Http;
using System.Xml.Serialization;

class Program{
  async static Task Main(){
  using(HttpClient tysken = new HttpClient()){
    tysken.BaseAddress = new Uri ("https://api.chucknorris.io");
    try{
HttpResponseMessage response = await tysken.GetAsync("jokes/random");
response.EnsureSuccessStatusCode();
string responseBody = await response.Content.ReadAsStringAsync();
Console.WriteLine(responseBody);
}
catch(HttpRequestException e){
  Console.WriteLine(e.Message);
}
}
  }
  
}

