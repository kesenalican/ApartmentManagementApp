using ApartmentManagement.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Entities.DTOs
{
    public class UserAddDto
    {
        [DisplayName("Kiracı Adı")]
        [Required(ErrorMessage ="{0}zorunludur")]
        [MaxLength(100,ErrorMessage ="{0} {1} karakterden büyük olmamalıdır.")]
        public string FirstName { get; set; }
        [DisplayName("Kiracı Soyadı")]
        [Required(ErrorMessage = "{0}zorunludur")]
        [MaxLength(100, ErrorMessage = "{0} {1} karakterden büyük olmamalıdır.")]
        public string LastName { get; set; }
        [DisplayName("Kiracı T.C")]
        [Required(ErrorMessage = "{0}zorunludur")]
        [MaxLength(11, ErrorMessage = "{0} {1} karakterden büyük olmamalıdır.")]
        public string IdentityNo { get; set; }
        [DisplayName("Kiracı Telefon No")]
        [Required(ErrorMessage = "{0}zorunludur")]
        [MaxLength(11, ErrorMessage = "{0} {1} karakterden büyük olmamalıdır.")]
        public string PhoneNumber { get; set; }
        [DisplayName("Kiracı Araç Plaka")]
        [MaxLength(15, ErrorMessage = "{0} {1} karakterden büyük olmamalıdır.")]
        public string CarPlate { get; set; }
        [DisplayName("Aylık Elektrik Faturası")]
        public int InvoiceElectricity { get; set; }
        [DisplayName("Aylık Su Faturası")]
        public int InvoiceWater { get; set; }
        [DisplayName("Aylık Doğalgaz Faturası")]
        public int InvoiceGas { get; set; }
        [DisplayName("Aylık İnternet Faturası")]
        public int InvoiceInternet { get; set; }
        [DisplayName("Daire Aidatı")]
        public string Dues { get; set; }
        public string Payment { get; set; }
        [DisplayName("Kiracı E-mail")]
        [Required(ErrorMessage = "{0} adresi zorunludur")]
        [RegularExpression("^[a-zA-Z0-9_.-]+@[a-zA-Z0-9-]+.[a-zA-Z0-9-.]+$", ErrorMessage = "Geçerli bir e-mail adresi giriniz!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DisplayName("Şifre")]
        [Required(ErrorMessage = "{0} Zorunludur!")]
        [RegularExpression("(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z]).{8,}", ErrorMessage = "Şifre en az 8 karakter olmalı ve bir büyük harf, bir küçük harf ve bir rakam içermelidir.")]
        [DataType(DataType.Password)]
        public byte[] PasswordHash { get; set; }

    }
}
