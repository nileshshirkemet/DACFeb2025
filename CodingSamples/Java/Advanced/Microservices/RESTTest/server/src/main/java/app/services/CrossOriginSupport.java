package app.services;

import java.io.IOException;

import jakarta.ws.rs.container.ContainerRequestContext;
import jakarta.ws.rs.container.ContainerResponseContext;
import jakarta.ws.rs.container.ContainerResponseFilter;
//import jakarta.ws.rs.ext.Provider;

//by default code running in the browser can only render a resource
//which originates from its own endpoint (same origin policy) unless
//the other endpoint permits cross origin resource sharing (CORS)
//by sending required headers to the browser
//@Provider
public class CrossOriginSupport implements ContainerResponseFilter {

    @Override
    public void filter(ContainerRequestContext requestContext, ContainerResponseContext responseContext) throws IOException {
        var headers = responseContext.getHeaders();
        headers.add("Access-Control-Allow-Origin", "http://localhost:5001");       
        headers.add("Access-Control-Allow-Methods", "*");
        headers.add("Access-Control-Allow-Headers", "*");
    }

    
}
