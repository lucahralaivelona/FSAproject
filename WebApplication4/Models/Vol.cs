namespace WebApplication4.Models
{
    public class Vol
    {
        public int numeroVol { get; set; }
        public int immatriculation { get; set; }
        public string reseau { get; set; }
        public TimeOnly gheurePiste { get; set; }
        public TimeOnly heureBloc { get; set; }
        public string destProv{ get; set; }
        public int paxC { get; set; }
        public int paxY{ get; set; }
        public int total { get; set; }
        public decimal IMMD { get; set; }
        public DateTime annee { get; set; }
        public DateTime mois { get; set; }
        public DateOnly jour { get; set; }
    }
}
