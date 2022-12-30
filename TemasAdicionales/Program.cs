var httpClient = new HttpClient();

var respuesta = await httpClient.GetAsync("https://localhost:7216/WeatherForecast");

var cuerpo = await respuesta.Content.ReadAsStringAsync();

Console.WriteLine(cuerpo);
