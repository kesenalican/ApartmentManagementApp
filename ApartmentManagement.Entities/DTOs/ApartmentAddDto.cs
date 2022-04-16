using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Entities.DTOs
{
    public class ApartmentAddDto
    {
        [DisplayName("Daire Blok")]
        [Required(ErrorMessage ="{0} boş olamaz")]
        public string Block { get; set; }
        [DisplayName("Daire Tipi örn: (2+1)")]
        [Required(ErrorMessage = "{0} boş olamaz")]
        public string Type { get; set; }
        [DisplayName("Daire Durumu")]
        [Required(ErrorMessage = "{0} boş olamaz")]
        public string Status { get; set; }
        [DisplayName("Daire Katı")]
        [Required(ErrorMessage = "{0} boş olamaz")]
        public string Floor { get; set; }
        [DisplayName("Daire No")]
        [Required(ErrorMessage = "{0} boş olamaz")]
        public int ApartmentNo { get; set; }
        [DisplayName("Durumu: Boş mu?")]
        [Required(ErrorMessage = "{0} boş olamaz")]
        public bool IsActive { get; set; }
    }
}
