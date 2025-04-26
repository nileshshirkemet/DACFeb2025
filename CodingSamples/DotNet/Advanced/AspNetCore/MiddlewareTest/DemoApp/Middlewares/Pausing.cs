namespace DemoApp.Middlewares;

public class Pausing(RequestDelegate next)
{
    private int recent = 0;

    public async Task Invoke(HttpContext context)
    {
        int current = Environment.TickCount;
        if(current - recent > 3000)
        {
            await next.Invoke(context);
            recent = current;
        }
        else
        {
            await context.Response.WriteAsync("Server busy, please try after some time...");
        }
    }
}
