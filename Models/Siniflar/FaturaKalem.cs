using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OnlineTicariOtomasyon.Models.Siniflar
{
	public class FaturaKalem
	{
        [Key]
        public int FaturaKalemID { get; set; }

        public int Miktar { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string Aciklama { get; set; }

        [Precision(7,2)]
        public decimal BirimFiyat { get; set; }

        [Precision(7, 2)]
        public decimal Tutar { get; set; }

        public int Faturaid { get; set; }

        public virtual Faturalar Faturalar { get; set; }
    }
}

