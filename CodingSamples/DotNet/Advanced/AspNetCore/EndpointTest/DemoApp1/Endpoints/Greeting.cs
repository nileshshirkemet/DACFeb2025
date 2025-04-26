namespace DemoApp.Endpoints;

public class Greeting
{
    public static async Task Ticks(HttpResponse response)
    {
        await response.WriteAsync(Environment.TickCount.ToString());
    }

    public static async Task Welcome(HttpResponse response)
    {
        await response.WriteAsync(
            $"""
            <html>
                <head>
                    <title>DemoApp</title>
                </head>
                <body>
                    <h1>Welcome Visitor</h1>
                    <p>
                        <b>Current Time: </b>{DateTime.Now}
                    </p>
                    <form method="POST" action="Login">
                        <b>Name: </b>
                        <input type="text" name="person"/>
                        <input type="submit" value="Sign In"/>
                    </form>
                </body>
            </html>
            """);
    }

    public static async Task Hello(HttpRequest request, HttpResponse response)
    {
        string user = request.Form["person"];
        int token = Random.Shared.Next(100000, 1000000);
        await response.WriteAsync(
            $"""
            <html>
                <head>
                    <title>DemoApp</title>
                </head>
                <body>
                    <h1>Hello {user}</h1>
                    <p>
                        <b>Your Secret Code: </b>{token}
                    </p>
                </body>
            </html>
            """);
    }
}

