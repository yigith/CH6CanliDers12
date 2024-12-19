using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoyaDoyaAnadolu.Data
{
    public class Sehir
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [MaxLength(50)]
        public string SehirAd { get; set; } = "";

        public int Nufus { get; set; }

        public int BolgeId { get; set; }


        public Bolge Bolge { get; set; } = null!;

    }
}
