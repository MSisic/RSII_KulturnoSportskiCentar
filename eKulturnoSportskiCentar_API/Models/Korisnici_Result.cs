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
    
    public partial class Korisnici_Result
    {
        public int KorisnikID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public Nullable<bool> Status { get; set; }

        public Nullable<int> BrojOcjenjenihDogadjaja { get; set; }
        public Nullable<int> BrojKreiranihDogadjaja { get; set; }
        public Nullable<int> BrojPosjecenihDogadjaja { get; set; }
    }
}
