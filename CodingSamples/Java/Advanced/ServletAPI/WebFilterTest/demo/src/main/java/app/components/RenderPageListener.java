package app.components;

import jakarta.servlet.ServletContext;
import jakarta.servlet.ServletContextEvent;
import jakarta.servlet.ServletContextListener;
import jakarta.servlet.annotation.WebListener;

@WebListener
public class RenderPageListener implements ServletContextListener {

    @Override
    public void contextInitialized(ServletContextEvent sce) {
        ServletContext context = sce.getServletContext();
        String pattern = System.getProperty("enable.page.rendering");
        if(pattern != null){
            var servlet = context.addServlet("renderingServlet", new RenderingServlet());
            servlet.addMapping(pattern);
        }
    }
    
    
}
