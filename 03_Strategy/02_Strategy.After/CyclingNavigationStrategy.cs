﻿namespace _02_Strategy.After;

public class CyclingNavigationStrategy : INavigationStrategy
{
    public Route Navigate(string origin, string destination)
    {
        return new Route
        {
            Title = "via Empire State Trl",
            Origin = origin,
            Destination = destination,
            RoutePreference = RoutePreference.Driving,
            DistanceInKM = 696,
            Duration = TimeSpan.FromHours(37).Add(TimeSpan.FromMinutes(0)),
            Directions = new()
            {
                origin,
                "Head southeast on Blvd Robert-Bourassa toward Boulevard René-Lévesque O/Bd René-Lévesque",
                "Turn left onto Boulevard René-Lévesque O/Bd René-Lévesque",
                "Continue onto Rue du Square-Victoria",
                "......",
                "Turn left onto NY-100 S/NY-133 W/Saw Mill River Rd",
                "....",
                "Slight left toward 12th Ave/Empire State Trl/Hudson River Greenway",
                "Continue onto City Hall Pk Path",
                destination
            }
        };
    }
}
