//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eKulturnoSportskiCentar_API.Models
{
    using System;
    
    public partial class esp_JavniDogadjaj_SelectByDogadjajID_Result
    {
        public Nullable<int> TerminID { get; set; }
        public int DogadjajID { get; set; }
        public string Dogadjaj { get; set; }
        public byte[] PlakatThumb { get; set; }
        public Nullable<int> BrojMijesta { get; set; }
        public System.DateTime Datum { get; set; }
        public System.TimeSpan Pocetak { get; set; }
        public string Vrsta { get; set; }
    }
}
