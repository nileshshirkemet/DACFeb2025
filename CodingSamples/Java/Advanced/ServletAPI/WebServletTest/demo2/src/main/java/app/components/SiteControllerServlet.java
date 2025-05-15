package app.components;

import java.io.IOException;

import com.google.gson.Gson;

import app.tourism.models.SiteModel;
import jakarta.servlet.ServletException;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;

@WebServlet("/api/site")
public class SiteControllerServlet extends HttpServlet {
    
    private SiteModel model = new SiteModel();

    private Gson serializer = new Gson();

    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        var visitors = model.getVisitors();
        response.setContentType("application/json");
        serializer.toJson(visitors, response.getWriter());
    }

    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        Feedback input = serializer.fromJson(request.getReader(), Feedback.class);
        if(!model.acceptVisit(input.person, input.rating))
            response.sendError(400); //bad request
    }

    
    
}
