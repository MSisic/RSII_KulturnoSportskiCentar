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
    using System.Collections.Generic;
    
    public partial class Dogadjaj
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dogadjaj()
        {
            this.DogadjajDodatnaOprema = new HashSet<DogadjajDodatnaOprema>();
            this.DogadjajOcjena = new HashSet<DogadjajOcjena>();
            this.KorisnikDogadjaj = new HashSet<KorisnikDogadjaj>();
        }
    
        public int DogadjajID { get; set; }
        public string Naziv { get; set; }
        public Nullable<int> VrstaDogadjajaID { get; set; }
        public Nullable<int> BrojMijesta { get; set; }
        public Nullable<bool> JavniDogadjaj { get; set; }
        public byte[] Plakat { get; set; }
        public byte[] PlakatThumb { get; set; }
        public Nullable<decimal> CijenaUlaza { get; set; }
        public Nullable<int> TerminID { get; set; }
        public Nullable<int> KorisnikID { get; set; }
        public Nullable<bool> Odobrena { get; set; }
    
        public virtual Korisnik Korisnik { get; set; }
        public virtual Termin Termin { get; set; }
        public virtual VrstaDogadjaja VrstaDogadjaja { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DogadjajDodatnaOprema> DogadjajDodatnaOprema { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DogadjajOcjena> DogadjajOcjena { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KorisnikDogadjaj> KorisnikDogadjaj { get; set; }
    }
}