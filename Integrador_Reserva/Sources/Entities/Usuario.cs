using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Integrador_Reserva.Sources.Entities
{
    public class Usuario
    {
        [Display(Name = "Código")]
        public int usuario_id { get; set; }

        [Display(Name = "Nombre")]
        public string usuario_nombre { get; set; }

        [Display(Name = "Clave")]
        public string usuario_contraseña { get; set; }

        [Display(Name = "Razón Social")]
        public string usuario_razonsocial { get; set; }

        [Display(Name = "RUC")]
        public string usuario_ruc { get; set; }

        [Display(Name = "E-mail")]
        public string usuario_email { get; set; }

        [Display(Name = "Tel/Cel.")]
        public string usuario_telefono { get; set; }

        [Display(Name = "Url Imagen")]
        public string usuario_foto_url { get; set; }

        [Display(Name = "Descripción")]
        public string usuario_presentacion { get; set; }
        public Boolean activo { get; set; }
    }
}