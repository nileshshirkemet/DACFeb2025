package app.components;

import java.io.IOException;
import java.util.Date;

import jakarta.servlet.ServletException;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;

@WebServlet("/greet/*")
public class GreetingServlet extends HttpServlet {

    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        String pi = request.getPathInfo();
        String name = pi != null ? pi.substring(1) : "Visitor";
        response.setContentType("text/html");
        response.getWriter().printf("""
                <html>
                    <head>
                        <title>simple-web-app</title>
                    </head>
                    <body>
                        <h1>Welcome %s</h1>
                        <b>Current Time: </b>%s
                    </body>
                </html>
                """, name, new Date());
    }
    
    
}
