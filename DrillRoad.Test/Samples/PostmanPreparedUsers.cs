using System.Collections.Generic;

namespace DrillRoad.Test.Samples
{
    public static class PostmanPreparedUsers
    {
        // Individual properties for each user
        public static string UserFromPostman1 => "userFromPostman1@user.pl";
        public static string UserFromPostman2 => "userFromPostman2@user.pl";
        public static string UserFromPostman3 => "userFromPostman3@user.pl";
        public static string UserFromPostman4 => "userFromPostman4@user.pl";
        public static string UserFromPostman5 => "userFromPostman5@user.pl";

        // Property to access the entire list of user names
        public static List<string> UserNames => new List<string>
        {
            UserFromPostman1,
            UserFromPostman2,
            UserFromPostman3,
            UserFromPostman4,
            UserFromPostman5
        };
    }
}