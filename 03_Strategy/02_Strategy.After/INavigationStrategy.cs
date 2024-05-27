namespace _02_Strategy.After;

public interface INavigationStrategy
{
    Route Navigate(string origin, string destination);
}

public class FlightNavigationStrategy : INavigationStrategy
{
    public Route Navigate(string origin, string destination)
    {
        return new Route
        {
            Title = "Montreal QC - NEW York, USA",
            Origin = origin,
            Destination = destination,
            RoutePreference = RoutePreference.Driving,
            DistanceInKM = 538,
            Duration = TimeSpan.FromHours(1).Add(TimeSpan.FromMinutes(20)),
            Directions = new()
            {
                origin,
                "Montréal-Pierre Elliott Trudeau International Airport (YUL)",
                "John F. Kennedy International Airport (JFK)",
                destination
            }
        };
    }
}
