using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineTicariOtomasyon.Models.Siniflar
{
	public class Kategori
	{
        [Key]
        public int KategoriID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string KategoriAd { get; set; }

        //HER KATEGORİMDE BİRDEN FAZLA ÜRÜN VARDIR

        public ICollection<Urun> Uruns { get; set; }
    }
}

