using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineTicariOtomasyon.Models.Siniflar
{
	public class KargoTakip
	{
        [Key]
		public int KargoTakipid { get; set; }

        [Column(TypeName = "Varchar(10)")]
        public string TakipKodu { get; set; }

        [Column(TypeName = "Varchar(100)")]
        public int Aciklama { get; set; }

        public DateTime TarihZaman{ get; set; }
    }
}

