using System;

namespace UtahRepeaters.Api.Database.Models {
    public class RawRepeater {
        public RawRepeater ()
        {
        }

        public string Band { get; set; }
        public string Input { get; set; }
        public float Output { get; set; }
        public string Callsign { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CoordinatesId { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Elevation { get; set; }
        public string StateCode { get; set; }
        public string Sponsor { get; set; }
        public string Source { get; set; }
        public string GeographicalArea { get; set; }
        public string Coordinated { get; set; }
        public string Open { get; set; }
        public string Closed { get; set; }
        public string Bilingual { get; set; }
        public string Experimental { get; set; }
        public string LITZ { get; set; }
        public string Tone { get; set; }
        public string CTCSS_IN { get; set; }
        public string CTCSS_OUT { get; set; }
        public string DCS { get; set; }
        public string DCS_CODE { get; set; }
        public string DTMF { get; set; }
        public string Remote_Base { get; set; }
        public string SNP { get; set; }
        public string Autopatch { get; set; }
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
        public string INTERNET { get; set; }
        public string INTERNET_LINK { get; set; }
        public string NOTES { get; set; }
        public string UPDATE { get; set; }
        public string COORD_DATE { get; set; }
        public string USE { get; set; }
        public string LATITUDE_DDMMSS { get; set; }
        public string LONGITUDE_DDDMMSS { get; set; }
        public string AMSL_FEET { get; set; }
        public string TX_POWER { get; set; }
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
        public string Location { get; set; }
    }
}