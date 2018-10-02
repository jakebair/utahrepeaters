namespace UtahRepeaters.Api.Database.Models
{
    public class Coordinates
    {
        public int CoordinatesId { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public int Elevation { get; set; }

        /// <summary>
        /// State Code
        /// </summary>
        public string StateCode { get; set; }

        /// <summary>
        /// Location - This is may be the town/city closest to the system, or it may be the name of the actual site.  
        /// </summary>
        public string Location { get; set; }

        public int RepeaterId { get; set; }
        public Repeater Repeater { get; set; }

    }
}