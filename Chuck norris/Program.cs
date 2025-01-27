using System.Net.Http;

class Program{
  static async void Main(){
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

