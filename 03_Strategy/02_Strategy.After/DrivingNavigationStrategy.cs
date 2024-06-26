﻿namespace _02_Strategy.After;

public class DrivingNavigationStrategy : INavigationStrategy
{
    public Route Navigate(string origin, string destination)
    {
        return new Route
        {
            Title = "via l-87 S",
            Origin = origin,
            Destination = destination,
            RoutePreference = RoutePreference.Driving,
            DistanceInKM = 596,
            Duration = TimeSpan.FromHours(6).Add(TimeSpan.FromMinutes(15)),
            Directions = new()
            {
                origin,
                "Head southeast on Blvd Robert-Bourassa toward Boulevard René-Lévesque O/Bd René-Lévesque [3 min.] (1.1 km)",
                "Follow A 15 S, I-87 S and NJ-17 S to Holland Tunnel in Jersey City, United States [5 hr 43 min.] (590 km)",
                "Continue on Holland Tunnel to your destination in Manhattan, New York [10 min.] (4.6 km)",
                destination
            }
        };
    }
}