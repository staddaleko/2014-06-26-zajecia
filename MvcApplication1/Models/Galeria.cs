﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Security;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Galeria
{
    public class Zdjecie_c
    {
        [Key]
        public int Id_z { set; get; }
        public string Wl { set; get; }
        public string Tytul { set; get; }
        public byte[] Zdjecie { set; get; }
        public DateTime Data_W { set; get; }
        public virtual ICollection<Komentarz_c> Komentarze { set; get; }
    }


    public class Komentarz_c
    {
        [Key]
        public int Id_k { set; get; }
        [Key]
        [ForeignKey("Zdjecie_c.Id_z")]
        public int Id_z { set; get; }
        public DateTime Data_w { set; get; }
        public string Komentarz { set; get; }
        public virtual Zdjecie_c Zdjecie { set; get; }

        
    }
}