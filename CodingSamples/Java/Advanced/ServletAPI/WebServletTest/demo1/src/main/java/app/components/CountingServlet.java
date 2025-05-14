package app.components;

import java.io.IOException;

import jakarta.servlet.ServletException;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;

@WebServlet("/login")
public class CountingServlet extends HttpServlet {

    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        String guest = request.getParameter("user");
        if(guest.length() == 0)
            guest = "Friend";
        response.setContentType("text/html");
        response.getWriter().printf("""
                <html>
                    <head>
                        <title>simple-web-app</title>
                    </head>
                    <body>
                        <h1>Hello %s</h1>
                        <b>Number of Greetings: </b>%d
                    </body>
                </html>
                """, guest, 1);
    }
    
    
}
