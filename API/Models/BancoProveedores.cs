using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class BancoProveedores
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string FormaPago { get; set; }
        [Required, StringLength(100)]
        public string Banco { get; set; }
        [Required, StringLength(50)]
        public string CuentaBancaria { get; set; }
        [StringLength(255)]
        public string ConceptoPago { get; set; }
        [StringLength(80)]
        public string NombreRazonSocial { get; set; }
        [StringLength(50)]
        public string Folio { get; set; }
        public byte[] Pdf { get; set; }
        [StringLength(50)]
        public string TipoCuenta { get; set; }
        [StringLength(255)]
        public string Sucursal { get; set; }
        [StringLength(50)]
        public string FolioEntrada { get; set; }
    }
}