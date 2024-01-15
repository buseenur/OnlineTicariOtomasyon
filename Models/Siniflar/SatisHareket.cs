using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace OnlineTicariOtomasyon.Models.Siniflar
{
	public class SatisHareket
	{
        [Key]
        public int SatisID { get; set; }

        public DateTime Tarih { get; set; }

        public int Adet { get; set; }

        [Precision(8, 2)]
        public decimal Fiyat { get; set; }

        [Precision(8, 2)]
        public decimal ToplamTutar { get; set; }

        public int Urunid { get; set; }

        public int Cariid { get; set; }

        public int Personelid { get; set; }

        public virtual Urun Urun { get; set; }

        public virtual Personel Personel { get; set; }

        public virtual Cariler Cariler { get; set; }

    }
}

