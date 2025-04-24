using DemoApp.Tourism.Data;

namespace DemoApp.Tourism.Models;

public class SiteModel
{
    public IEnumerable<Visitor> GetVisitors()
    {
        using var site = new SiteDbContext();
        var selection = from t in site.Travellers
            where t.Id.Length > 3
            select new Visitor 
            {
                Name = t.Id,
                Stars = new string('*', t.Rating),
                Visits = t.Tours.Count,
                Recent = t.Tours.Max(e => e.Checkin)
            };
        return selection.ToList();
    }

    public void AcceptVisit(string visitorId, int visitorRating)
    {
        using var site = new SiteDbContext();
        var traveller = site.Travellers.Find(visitorId);
        if(traveller is null)
        {
            traveller = new Traveller { Id = visitorId };
            site.Travellers.Add(traveller);
        }
        traveller.Tours.Add(new Trip());
        traveller.Rating = visitorRating;
        site.SaveChanges();
    }
}