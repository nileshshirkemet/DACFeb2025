package app.tourism.models;

import java.util.Comparator;
import java.util.Date;

import app.tourism.data.TravelerEntity;
import app.tourism.data.TripEntity;

public record Visitor(String name, String stars, int visits, Date recent) {
    
    public static Visitor fromTraveler(TravelerEntity entity) {
        var trips = entity.getTours();
        return new Visitor(
            entity.getId(),
            "*".repeat(entity.getRating()),
            trips.size(),
            trips.stream().map(TripEntity::getCheckin).max(Comparator.naturalOrder()).get()
        );
    }
}
