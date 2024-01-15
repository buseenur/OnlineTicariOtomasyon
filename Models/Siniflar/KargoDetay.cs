﻿using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineTicariOtomasyon.Models.Siniflar
{
	public class KargoDetay
	{
		[Key]
		public int KargoDetayid { get; set; }

        [Column(TypeName = "Varchar(300)")]
        public string Aciklama { get; set; }

        [Column(TypeName = "Varchar(10)")]
        public string TakipKodu { get; set; }

        [Column(TypeName = "Varchar(20)")]
        public string Personel { get; set; }

        [Column(TypeName = "Varchar(20)")]
        public string Alici { get; set; }

        public DateTime Tarih { get; set; }
    }
}
