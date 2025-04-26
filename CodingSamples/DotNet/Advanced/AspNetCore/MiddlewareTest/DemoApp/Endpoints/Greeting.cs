namespace DemoApp.Endpoints;

public class Greeting
{
    public static async Task Welcome(HttpContext context, string name = "Visitor")
    {
        await context.Response.WriteAsync(
            $"""
            <html>
                <head>
                    <title>DemoApp</title>
                </head>
                <body>
                    <h1>Welcome {name}</h1>
                    <b>Current Time: </b>{DateTime.Now}
                </body>
            </html>
            """);
    }

    public async static Task Hello(HttpContext context)
    {
        string name = context.Request.Form["person"];
        int count = context.Session.GetInt32(name) ?? 1;
        context.Session.SetInt32(name, count + 1);
        await context.Response.WriteAsync(
            $"""
            <html>
                <head>
                    <title>DemoApp</title>
                </head>
                <body>
                    <h1>Hello {name}</h1>
                    <b>Number of Greetings: </b>{count}
                </body>
            </html>
            """);
    }
}