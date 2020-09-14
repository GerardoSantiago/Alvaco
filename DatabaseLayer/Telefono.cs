namespace DatabaseLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Telefono")]
    public partial class Telefono
    {
        public int Id { get; set; }

        [Required]
        [StringLength(60)]
        public string Lada { get; set; }

        [Required]
        [StringLength(60)]
        public string Numero { get; set; }

        [StringLength(60)]
        public string Extension { get; set; }

        public int? EmpleadoId { get; set; }

        public virtual Empleado Empleado { get; set; }
    }
}
