using System;
using System.Collections.Generic;
using System.Linq;


public static class StarlinkSolution
{

    /// <summary>
    /// 
    /// 
    /// </summary>
    /// <param name="Vector3">(float x, float y, float z)</param>
    /// <param name="Sat">integer</param>
    /// <param name="User">integer</param>
    /// <returns></returns>
    public static Dictionary<User, (Sat, Color)> Solve(Dictionary<User, Vector3> users, Dictionary<Sat, Vector3> sats)
    {

        // TODO: Implement.
        // Given entire dictionary
        // 
        // Color = A, B, C, D

        var MaxUsers = 32;
        var UsersOnline = users.Count;
        var SatOnline = sats.Count;
        var Vectorutilities = new Vector3(0,0,0);

        var solution = new Dictionary<User, (Sat, Color)>();

        Dictionary<int, float> UserServiceAvailable = new Dictionary<int, float>();
        Dictionary<int, float> SateliteUsersSupported = new Dictionary<int, float>();

        foreach (var userEntry in users)
        {
            var user = userEntry.Key;
            var userPosition = userEntry.Value;

            foreach (var satEntry in sats)
            {
                var sat = satEntry.Key;
                var satPosition = satEntry.Value;

                var angleBetweenUserAndSat = Vectorutilities.AngleBetween(satPosition, userPosition);

                //if (angleBetweenUserAndSat <= 45)
                //{
                //    UserServiceAvailable[user] = angleBetweenUserAndSat;
                //}
                //else
                //{
                //    // Handle the case where the angle is greater than 45 degrees
                //    UserServiceAvailable[user] = null;
                //}
            }
        }



        // assign a satelite color to user

        // check distance

        // 

        return solution;
    }

}
