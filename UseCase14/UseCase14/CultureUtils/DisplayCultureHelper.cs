using System.Globalization;

namespace UseCase14.CultureUtils
{
    public static class DisplayCultureHelper
    {
        public static string DisplayWeight(double kg)
        {
            var currentCulture = CultureInfo.CurrentCulture;
            // Assume that only the "en-US" culture uses pounds
            if (currentCulture.Name.Equals("en-US"))
            {
                return (kg * 2.20462).ToString(currentCulture); // convert kg to pounds
            }
            else
            {
                return kg.ToString(currentCulture); // return the original value if not "en-US" culture
            }
        }

        public static string DisplayLength(double cm)
        {
            var currentCulture = CultureInfo.CurrentCulture;
            // Assume that only the "en-US" culture uses pounds
            if (currentCulture.Name.Equals("en-US"))
            {
                return (cm * 0.3937).ToString(currentCulture); // convert cm to inches
            }
            else
            {
                return cm.ToString(currentCulture); // return the original value if not "en-US" culture
            }
        }

        public static string DisplayCapacity(double l)
        {
            var currentCulture = CultureInfo.CurrentCulture;
            // Assume that only the "en-US" culture uses pounds
            if (currentCulture.Name.Equals("en-US"))
            {
                return (l * 33.8140227).ToString(currentCulture); // convert l to oz
            }
            else
            {
                return l.ToString(currentCulture); // return the original value if not "en-US" culture
            }
        }
    }
}
