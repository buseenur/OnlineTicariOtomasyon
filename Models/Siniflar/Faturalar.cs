using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OnlineTicariOtomasyon.Models.Siniflar
{
	public class Faturalar
	{
        [Key]
        public int FaturaID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(6)]
        public string FaturaSıraNo { get; set; }

        [Column(TypeName = "Char")]
        [StringLength(1)]
        public string FaturaSeriNo { get; set; }

        public DateTime Tarih { get; set; }

        [Column(TypeName = "Char")]
        [StringLength(5)]
        public string Saat { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string VergiDairesi { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string TeslimEden { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string TeslimAlan { get; set; }

        [Precision(7,2)]
        public decimal Toplam { get; set; }


        //BİR FATURANIN BİRDEN FAZLA FATURAKALEMİ OLUR
        public ICollection<FaturaKalem> FaturaKalems { get; set; }
    }
}

