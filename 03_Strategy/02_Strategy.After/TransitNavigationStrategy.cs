﻿namespace _02_Strategy.After;

public class TransitNavigationStrategy : INavigationStrategy
{
    public Route Navigate(string origin, string destination)
    {
        return new Route
        {
            Title = "Greyhound",
            Origin = origin,
            Destination = destination,
            RoutePreference = RoutePreference.Driving,
            DistanceInKM = 598,
            Duration = TimeSpan.FromHours(9).Add(TimeSpan.FromMinutes(20)),
            Directions = new()
            {
                origin,
                "Montreal Greyhound",
                "Port Authority Bus Terminal (9 hr 20 min)",
                destination
            }
        };
    }
}