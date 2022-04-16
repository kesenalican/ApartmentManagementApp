using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Entities.DTOs
{
    public class UserAddInvoicesDto
    {
        [DisplayName("Aylık Elektrik Faturası")]
        [Required(ErrorMessage="{0} alanı zorunludur")]
        public int InvoiceElectricity { get; set; }
        [DisplayName("Aylık Su Faturası")]
        [Required(ErrorMessage = "{0} alanı zorunludur")]
        public int InvoiceWater { get; set; }
        [DisplayName("Aylık Doğalgaz Faturası")]
        [Required(ErrorMessage = "{0} alanı zorunludur")]
        public int InvoiceGas { get; set; }
        [DisplayName("Aylık İnternet Faturası")]
        [Required(ErrorMessage = "{0} alanı zorunludur")]
        public int InvoiceInternet { get; set; }
        [DisplayName("Daire Aidatı")]
        [Required(ErrorMessage = "{0} alanı zorunludur")]
        public string Dues { get; set; }
    }
}
