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
    
    public partial class DogadjajiZaAdministraciju_Result
    {
        public int DogadjajID { get; set; }
        public string Dogadjaj { get; set; }
        public string Vrsta { get; set; }
        public int VrstaDogadjajaID { get; set; }
        public System.DateTime Datum { get; set; }
        public string Satnica { get; set; }
        public string Sala { get; set; }
        public int SalaID { get; set; }
        public Nullable<bool> Javni { get; set; }
        public string korisnik { get; set; }
    }
}
