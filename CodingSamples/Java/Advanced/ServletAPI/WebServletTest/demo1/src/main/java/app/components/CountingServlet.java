package app.components;

import java.io.IOException;

import jakarta.servlet.ServletException;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import jakarta.servlet.http.HttpSession;

@WebServlet("/login")
public class CountingServlet extends HttpServlet {

    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        String guest = request.getParameter("user");
        if(guest.length() == 0)
            guest = "Friend";
        HttpSession session = request.getSession(true);
        Integer count = (Integer)session.getAttribute(guest);
        if(count == null)
            count = 1;
        session.setAttribute(guest, count + 1);
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
                """, guest, count);
    }
    
    
}
