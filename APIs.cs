//APIs.cs

using System;
using System.Net.Http;

var client = new HttpClient();

var request = new HttpRequestMessage(
    method: HttpMethod.Get, 
    requestUri: "https://api.collection.cooperhewitt.org/rest/?method=cooperhewitt.search.objects&query=clock%20radio&page=1&per_page=100&access_token=b6e49cffad481f913fa21542c2da21aa"
);

HttpResponseMessage response = await client.SendAsync(request);

if (response.IsSuccessStatusCode)
{
    string responseContent = await response.Content.ReadAsStringAsync();

    Console.WriteLine(responseContent);
}

//var client = new HttpClient();
/*
var request = new HttpRequestMessage(
    method: HttpMethod.Post,
    requestUri: "http://localhost:3000/objects"
); */

string payload = @"{""id"":5,""item"":""The Fiancés"",""artist"":""Pierre Auguste Renoir"",""collection"":""Wallraf–Richartz Museum, Cologne, Germany"",""date"":""1868""}";

var requestData = new StringContent(
    content: payload, 
    encoding: System.Text.Encoding.UTF8,
    mediaType: "application/json"
);

request.Content = requestData;

//HttpResponseMessage response = await client.SendAsync(request);

if (response.IsSuccessStatusCode)
{
    string responseContent = await response.Content.ReadAsStringAsync();

    Console.WriteLine(responseContent);
}