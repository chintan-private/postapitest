
Imports Microsoft.AspNetCore.Mvc

Namespace Controllers
        <Route("api/[controller]")>
        <ApiController>
        Public Class WeatherForecastController
            Inherits ControllerBase

        Private Shared ReadOnly Summaries As String() = New String() {
            "Chintan", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        }

        <HttpGet>
            Public Function Get() As IEnumerable(Of WeatherForecast)
                Dim rng As New Random()
                Return Enumerable.Range(1, 5).Select(Function(index) New WeatherForecast With {
                .Date = DateTime.Now.AddDays(index),
                .TemperatureC = rng.Next(-20, 55),
                .Summary = Summaries(rng.Next(Summaries.Length))
            }).ToArray()
            End Function
        End Class

        Public Class WeatherForecast
            Public Property Date As DateTime
            Public Property TemperatureC As Integer
            Public Property Summary As String
        End Class
    End Namespace

