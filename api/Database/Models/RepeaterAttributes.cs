namespace UtahRepeaters.Api.Database.Models
{
    using System;

    public class RepeaterAttributes 
    {
        public int RepeaterAttributesId { get; set; }

        /// <summary>
        /// Sponsor - This field may contain an abbreviation of the sponsoring group or club, the callsign of the trustee, or nothing at all (as in those cases where such information is unknown.)
        /// </summary>
        /// <value></value>
        public string Sponsor { get; set; }

        /// <summary>
        /// Source - This field may contain an abbreviation of the sponsoring group or club, the callsign of the trustee, or nothing at all (as in those cases where such information is unknown.)
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// GeographicalArea - This field indicates the general coverage area of this repeater.  This data in this fields is very generic so that it may hopefully mean something to someone unfamiliar with the area. The data in this field, while it may be significant to the frequency coordinator, may not be wholly useful to the local user who may be more familiar with local place-names.  A new field has been added that contains more user-relevant information (see the "Coverage Area" field below for more specific information.).
        /// </summary>
        public string GeographicalArea { get; set; }

        public bool Coordinated { get; set; }
        public bool Open { get; set; }
        public bool Closed { get; set; }
        public bool Bilingual { get; set; }
        public bool Experimental { get; set; }
        public bool LITZ { get; set; }
        public bool Tone { get; set; }

        public int CTCSS_IN { get; set; }
        public int CTCSS_OUT { get; set; }
        public bool DCS { get; set; }
        public string DCS_CODE { get; set; }

        public bool DTMF { get; set; }
        public bool Remote_Base { get; set; }
        public bool SNP { get; set; }
        public bool Autopatch { get; set; }
        public string Patch_Seq { get; set; }

        public string CLOSED_PATCH { get; set; }
        public string EMERG_POWER { get; set; }
        public string EMERG_SUN { get; set; }
        public string EMERG_WIND { get; set; }
        public string LINKED { get; set; }
        public string LINKED_FREQ { get; set; }
        public string PORTABLE { get; set; }
        public string RACES { get; set; }
        public string ARES { get; set; }
        public string WIDE_AREA { get; set; }
        public string LAW { get; set; }
        public string LAW_DTMF { get; set; }
        public string WEATHER { get; set; }
        public string WEATHER_DTMF { get; set; }

        // Extended Attributes
        public bool INTERNET { get; set; }
        public string INTERNET_LINK { get; set; }
        public string NOTES { get; set; }
        public DateTime UPDATE { get; set; }
        public DateTime COORD_DATE { get; set; }
        public string USE { get; set; }
        public string LATITUDE_DDMMSS { get; set; }
        public string LONGITUDE_DDDMMSS { get; set; }
        public int AMSL_FEET { get; set; }
        public int TX_POWER { get; set; }
        public string ANT_INFO { get; set; }
        public string ERP { get; set; }
        public string PUB_CODE { get; set; }
        public string ACTIVE { get; set; }
        public string SITE_NAME { get; set; }
        public string COVERAGE_AREA { get; set; }
        public string FOOTNOTES { get; set; }
        public string CONTACT_EMAIL { get; set; }
        public string REPEATER_WEB_PAGE { get; set; }
        public string MAPSEL { get; set; }
        public string CONTACT_PHONE { get; set; }
        public string UPDATE_SOURCE { get; set; }
        public string COORD_NOTES { get; set; }
        public string CONTACT_MAIL { get; set; }
    }
}