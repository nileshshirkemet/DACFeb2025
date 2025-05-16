package app.components;

import java.io.FileNotFoundException;
import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Path;
import java.util.concurrent.atomic.AtomicInteger;

import jakarta.servlet.ServletContext;
import jakarta.servlet.ServletException;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;

public class RenderingServlet extends HttpServlet {

    private AtomicInteger counter = new AtomicInteger();

    @Override
    protected void service(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        ServletContext context = super.getServletContext();
        String page = request.getServletPath();
        String pageFile = context.getRealPath(page);
        String guest = request.getParameter("user");
        if(guest == null || guest.length() == 0)
            guest = "Friend";
        int count = counter.incrementAndGet();
        try{
            String content = Files.readString(Path.of(pageFile))
                .replace("|visitor.name|", guest)
                .replace("|greet.count|", String.valueOf(count));
            response.setContentType("text/html");
            response.getWriter().print(content);
        }catch(FileNotFoundException e){
            response.sendError(404);
        }
    }
    
    
}
