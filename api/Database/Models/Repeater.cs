namespace UtahRepeaters.Api.Database.Models
{
    public class Repeater
    {
        public int RepeaterId { get; set; }

        /// <summary>
        /// Band
        ///     This field is used to specify both the amateur band on which the system operates and the use.  It is defined as follows:
        ///     29 - 10 Meters
        ///     52 - 6 Meters
        ///     144 - 2 Meters
        ///     220 - 1.25 Meters
        ///     440 - 70 cm
        ///     902 - 33 cm
        ///     1240 - 23cm
        ///     500 - Designates Amateur Television, regardless of band
        ///     2000 - Designates Packet operation, regardless of band
        ///     2400 - 13cm
        ///     3000 - 9cm
        ///     5000 - 6cm
        ///     10000 - 3cm
        /// </summary>
        public int Band { get; set; }

        /// <summary>
        /// Input Frequency in MHz
        /// </summary>
        public double? Input { get; set; }

        /// <summary>
        /// Output Frequency in MHz
        /// </summary>
        public double? Output { get; set; }

        /// <summary>
        /// Callsign - This field contains the callsign used by the system in question for identification.  This may not always be the callsign of the trustee.
        /// </summary>
        public string Callsign { get; set; }
        
        public string Name { get; set; }

        public string Description { get; set; }

        public Coordinates Coordinates { get; set; }

        public RepeaterAttributes Attributes { get; set; }
    }
}