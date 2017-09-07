using System;
using System.ComponentModel.DataAnnotations;

namespace FraudeUitwisseling.Fraudeberichten
{
    public class Fraudesignaal
    {
        public int FraudesignaalId { get; set; }
        public FraudeID FraudeID { get; set; }
        public virtual Status Status { get; set; }
        public virtual Routering Routering { get; set; }
        public virtual Contactpersoon Contactpersoon { get; set; }
        public virtual Betrokkene Betrokkenen { get; set; }
        public virtual Melder Melder { get; set; }
        public virtual ZorgID ZorgIDs { get; set; }
        public virtual Dossier Dossier { get; set; }
        //public virtual List<Betrokkene> Betrokkenen { get; set; }
        //public virtual List<Melder> Melder { get; set; }
        //public virtual List<ZorgID> ZorgIDs { get; set; }
        //public virtual List<Dossier> Dossier { get; set; }
    }

    public class Dossier
    {
        public int DossierId { get; set; }
        public Decimal Bedrag { get; set; }
    }

    public class ZorgID
    {
        public int ZorgIDId { get; set; }
        [MaxLength(2)]
        public string VerzekeringWet { get; set; }
        [MaxLength(2)]
        public string Leveringsvorm { get; set; }
        [MaxLength(2)]
        public string ZorgSoort { get; set; }
    }

    public class Melder
    {
        public int MelderId { get; set; }
        [MaxLength(2)]
        public string AanleverWijze { get; set; }
        [MaxLength(2)]
        public string MelderType { get; set; }
    }

    public class Betrokkene
    {
        public string BetrokkeneID { get; set; }
    }

    public class Contactpersoon
    {
        public int ContactpersoonId { get; set; }
        public NatuurlijkPersoonNaam NatuurlijkPersoonNaam { get; set; }
        public Adres Adres { get; set; }
        [MaxLength(15)]
        public string Telefoonnummers { get; set; }
        [MaxLength(70)]
        public string EmailAdres { get; set; }

    }

    public class NatuurlijkPersoonNaam
    {
        public int NatuurlijkPersoonNaamId { get; set; }
        [MaxLength(25)]
        public string Achternaam { get; set; }
    }

    public class Adres
    {
        public int AdresId { get; set; }
        [MaxLength(24)]
        public string Straatnaam { get; set; }
    }

    public class Routering
    {
        public int RouteringId { get; set; }
        public Enums.NawZichtbaarEnum NawZichtbaar { get; set; }
        public Enums.OntvangerbekendEnum Ontvangerbekend { get; set; }
        public Ontvanger Ontvangers { get; set; }
    }

    public class Ontvanger
    {
        public int OntvangerId { get; set; }
    }

    public class Status
    {
        public int StatusId { get; set; }
        [MaxLength(2)]
        public string FraudeStatus { get; set; }
        [MaxLength(2)]
        public string OnderzoekResultaat { get; set; }
        [MaxLength(2)]
        public string Maatregelen { get; set; }
    }

    public class FraudeID
    {
        public int FraudeIDId { get; set; }
        public Enums.SignaalTypeEnum SignaalType { get; set; }
        public int SignaalNummer { get; set; }
        public DateTime AanleverDatumTijd { get; set; }
        [MaxLength(3)]
        public string AanleverOrganisatieID { get; set; }
        public string InternKenmerk { get; set; }
        public Enums.NawZichtbaarEnum Routeren { get; set; }
        public DateTime SignaleringDatumTijd { get; set; }
    }
}


